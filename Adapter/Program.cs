using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IMusicPlayer player = new SimpleMusicPlayer();

            IAdvancedMusicPlayer advancedMusicPlayer = new AdvancedMusicPlayer();

            IMusicPlayer adapterPlayer = new AdvancedPlayerAdapter(advancedMusicPlayer);

            player.Play("mp3");
            player.Play("mp4");
            player.Play("mkv");
            player.PlayFile("abc.mp4");
            player.Stop();

            advancedMusicPlayer.PlayMp3();
            advancedMusicPlayer.PlayMp4();
            string[] list = { "abc.mp3" };
            advancedMusicPlayer.LoadPlaylist(list);
            advancedMusicPlayer.PlayNext();
            advancedMusicPlayer.Stop();

            adapterPlayer.Play("mp3");
            adapterPlayer.Play("mp4");
            adapterPlayer.Play("mkv");
            adapterPlayer.PlayFile("abc.mp4");
            adapterPlayer.Stop();
        }
    }
}
