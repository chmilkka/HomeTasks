using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12
{
    internal interface IRecordable
    {
        public void Record();
        public void Pause();
        public void Stop();
    }
}
