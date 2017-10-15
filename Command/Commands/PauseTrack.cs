using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class PauseTrack : Command
    {
        IMusicPlayer player;

        public PauseTrack(IMusicPlayer player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.Pause();
        }

        public void undo()
        {
            this.player.Play();
        }
    }
}
