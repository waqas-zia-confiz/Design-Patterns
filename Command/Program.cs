using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //Act as invoker
            IMusicPlayer musicPlayer = new MusicPlayer();
            IRemote remoteControl = new PlayerRemote(musicPlayer);
            remoteControl.PressNextButton();
            remoteControl.PressPauseButton();
            remoteControl.PressPlayButton();
            remoteControl.PressPreviousButton();
            remoteControl.PressStopButton();
        }
    }
}
