using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IAdvancedMusicPlayer
    {
        void PlayMp4();
        void PlayMp3();
        void PlayOther();
        void PlayNext();
        void Stop();
        void LoadPlaylist(string[] list);
    }
}
