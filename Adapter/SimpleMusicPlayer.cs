using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SimpleMusicPlayer : IMusicPlayer
    {
        public void Play(string format)
        {
            Console.WriteLine("Playing " + format + " file");
        }

        public void PlayFile(string filename)
        {
            Console.WriteLine("Playing " + filename );
        }

        public void Stop()
        {
            Console.WriteLine("Stopping..");
        }
    }
}
