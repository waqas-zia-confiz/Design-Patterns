using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface IMusicPlayer
    {
        void Play();
        void Pause();
        void Stop();
        void Next();
        void Previous();
    }
}
