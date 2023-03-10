using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask11
{
    internal class ClassRoom
    {
        public Pupil[] pupils;
        public ClassRoom()
        {
            //Композиція
            //В умові написано що у класі 4 учні, зробив двох середнячків, одного відмінника та одного двієчника
            pupils = new Pupil[]
            {
                new ExcelentPupil(){},
                new GoodPupil(){},
                new GoodPupil(){},
                new BadPupil(){},
            };
        } 
    }
}
