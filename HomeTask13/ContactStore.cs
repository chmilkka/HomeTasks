using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTask13
{
    internal class ContactStore : BaseContactStore
    {
        
        public ContactStore(IContactProvider contactProvider) : base(contactProvider)
        {
        }

        public override void Create(IContact contact)
        {
            foreach ( var c in _contacts)
            {
                if (c.Name == contact.Name)
                {
                    throw new DeniedOperationException($"Contact with {nameof(contact.Name)} {contact.Name} is already exists");
                }
            }
            contact.Id = _contacts.Count + 1;
           _contacts.Add(contact);
        }

        public override IContact GetById(int id)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                { 
                    return contact;
                }
            }
            return null;
        }

        public override IEnumerable<IContact> GetByName(string name)
        {
            List<IContact> contacts = new List<IContact>();
            foreach(var contact in _contacts)
            {
                if (contact.Name.Equals(name))
                {
                    contacts.Add(contact);
                }
            }
            return contacts;
        }

        public override IEnumerable<IContact> GetByPhoneNumber(string phoneNumber)
        {
            List<IContact> contacts = new List<IContact>();
            foreach (var contact in _contacts)
            {
                if (contact.PhoneNumber.Equals(phoneNumber))
                {
                    contacts.Add(contact);
                }
            }
            return contacts;
        }

        public override bool Remove(int id)
        {
            foreach (var contact in _contacts)
            {
                if( contact.Id == id)
                {
                    _contacts.Remove(contact);
                    return true;
                }
            }
            throw new DeniedOperationException($"Contact with contact.Id {id} is not exists");
        }

        public override void Update(IContact contact)
        {
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].Id == contact.Id)
                {
                    _contacts[i] = contact;
                    break;
                }
            }
        }
    }
}
