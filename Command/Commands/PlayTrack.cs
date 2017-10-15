using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class PlayTrack : Command
    {
        IMusicPlayer player;

        public PlayTrack(IMusicPlayer player)
        {
            this.player = player;
        }

        public void execute()
        {
            this.player.Play();
        }

        public void undo()
        {
            this.player.Stop();
        }
    }
    
}
