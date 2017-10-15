using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Invoker class
    public class PlayerRemote : IRemote
    {
        IMusicPlayer player;

        public PlayerRemote(IMusicPlayer player)
        {
            this.player = player;
        }

        public void PressNextButton()
        {
            Command cmd = new NextTrack(player);
            cmd.execute();
        }

        public void PressPauseButton()
        {
            Command cmd = new PauseTrack(player);
            cmd.execute();
        }

        public void PressPlayButton()
        {
            Command cmd = new PlayTrack(player);
            cmd.execute();
        }

        public void PressPreviousButton()
        {
            Command cmd = new PreviousTrack(player);
            cmd.execute();
        }

        public void PressStopButton()
        {
            Command cmd = new StopTrack(player);
            cmd.execute();
        }
    }
}
