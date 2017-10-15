using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface IRemote
    {
        void PressPlayButton();
        void PressPauseButton();
        void PressStopButton();
        void PressNextButton();
        void PressPreviousButton();
    }
}
