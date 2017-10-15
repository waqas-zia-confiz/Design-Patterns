using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class MusicPlayer : IMusicPlayer
    {
        public void Next()
        {
            Console.WriteLine("Playing Next Track");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing Track");
        }

        public void Play()
        {
            Console.WriteLine("Playing Track");
        }

        public void Previous()
        {
            Console.WriteLine("Playing Previous Track");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping Music");
        }
    }
}
