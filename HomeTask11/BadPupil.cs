using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HomeTask11
{
    internal class BadPupil : Pupil
    {
        //Приклад навчання слабкого учня
        public override void Study()
        {
            Console.WriteLine("Studying is so boring");
        }
        public override void Read()
        {
            Console.WriteLine("I read badly");
        }
        public override void Write()
        {
            Console.WriteLine("I write badly");
        }
        public override void Relax()
        {
            Console.WriteLine("I rest all day");
        }
    }
}
