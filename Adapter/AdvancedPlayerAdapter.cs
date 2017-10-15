using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdvancedPlayerAdapter : IMusicPlayer
    {
        IAdvancedMusicPlayer musicPlayer;
        public AdvancedPlayerAdapter(IAdvancedMusicPlayer musicPlayer)
        {
            this.musicPlayer = musicPlayer;
        }
        public void Play(string format)
        {
            if (format == "mp3")
                this.musicPlayer.PlayMp3();
            else if (format == "mp4")
                this.musicPlayer.PlayMp4();
            else
                this.musicPlayer.PlayOther();
        }

        public void PlayFile(string filename)
        {
            string[] fileNameList = { filename }; 
            this.musicPlayer.LoadPlaylist(fileNameList);
            this.musicPlayer.PlayNext();
        }

        public void Stop()
        {
            this.musicPlayer.Stop();
        }
    }
}
