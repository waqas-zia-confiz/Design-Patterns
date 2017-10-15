using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class StopTrack : Command
    {
        IMusicPlayer player;

        public StopTrack(IMusicPlayer player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.Stop();
        }

        public void undo()
        {
            this.player.Play();
        }
    }
    
}
