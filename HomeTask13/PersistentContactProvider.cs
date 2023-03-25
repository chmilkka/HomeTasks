using HomeTask13.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    internal class PersistentContactProvider : IContactProvider, IContactSaveable
    {
        public IEnumerable<IContact> Get()
        {
            const string path = @"C:\Users\Chmil\Desktop\Contacts.txt";

            List<IContact> contacts = new List<IContact>();

            if (File.Exists(path) && File.ReadAllLines(path) != null)
            {
                string[] allLines = File.ReadAllLines(path);
                for (int i = 0; i < allLines.Length; i++)
                {
                    string[] line = allLines[i].Split(" ");
                    contacts.Add(new Contact()
                    {
                        Id = Convert.ToInt32(line[0]),
                        Name = line[1],
                        PhoneNumber = line[2],
                    });
                }
            }
            
            return contacts;
        }
        public bool Save(IEnumerable<IContact> items)
        {
            const string path = @"C:\Users\Chmil\Desktop\Contacts.txt";

            if (!File.Exists(path)) File.Create(path);

            try
            {
                var sw = new StreamWriter(path);

                foreach (var item in items)
                {
                    sw.WriteLine(item.Id + " " + item.Name + " " + item.PhoneNumber);
                }
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}

