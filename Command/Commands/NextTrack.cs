using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class NextTrack : Command
    {
        IMusicPlayer player;

        public NextTrack(IMusicPlayer player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.Next();
        }

        public void undo()
        {
            this.player.Previous();
        }
    }
}
