using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12
{
    internal class Player : IRecordable, IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Pause...");
        }

        public void Play()
        {
            Console.WriteLine("Started to play track"); 
        }

        public void Record()
        {
            Console.WriteLine("Started to record sounds");
        }

        public void Stop()
        {
            Console.WriteLine("Overstart..."); //Якщо я правильно зрозумів, то цей метод має запускати трек або запис спочатку
        }
    }
}
