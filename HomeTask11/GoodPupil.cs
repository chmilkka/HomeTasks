using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    internal class GoodPupil : Pupil
    {
        //Приклад навчання середньго учня
        public override void Study()
        {
            Console.WriteLine("I study well");
        }
        public override void Read()
        {
            Console.WriteLine("I'm good at reading");
        }
        public override void Write()
        {
            Console.WriteLine("I'm good at writing");
        }
        public override void Relax()
        {
            Console.WriteLine("I like to rest");
        }
    }      
}
