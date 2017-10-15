using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdvancedMusicPlayer : IAdvancedMusicPlayer
    {
        public void LoadPlaylist(string[] list)
        {
            Console.WriteLine("Loading playlist.");
        }

        public void PlayMp3()
        {
            Console.WriteLine("Playing mp3 file");
        }
        public void PlayMp4()
        {
            Console.WriteLine("Playing mp4 file");
        }
        public void PlayNext()
        {
            Console.WriteLine("Playing Next Song in the List");
        }

        public void PlayOther()
        {
            Console.WriteLine("Playing file in other format.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping...");
        }
    }
}
