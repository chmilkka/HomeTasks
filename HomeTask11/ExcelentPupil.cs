using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    internal class ExcelentPupil : Pupil
    {
        //Приклад навчання учня відмінника
        public override void Study()
        {
            Console.WriteLine("I am an excellent pupil");
        }
        public override void Read()
        {
            Console.WriteLine("I read perfectly");
        }
        public override void Write()
        {
            Console.WriteLine("I write perfectly");
        }
        public override void Relax()
        {
            Console.WriteLine("Rest for a while after studying");
        }
    }
}
