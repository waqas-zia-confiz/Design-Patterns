using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IMusicPlayer
    {
        void Play(string format);
        void Stop();
        void PlayFile(string filename);
    }
}
