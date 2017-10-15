using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class PreviousTrack : Command
    {
        IMusicPlayer player;

        public PreviousTrack(IMusicPlayer player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.Previous();
        }

        public void undo()
        {
            this.player.Next();
        }
    }
}
