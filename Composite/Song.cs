using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Song:SongComponent
    {
        private string songName;
        private string bandName;

        public Song(string songName, string bandName)
        {
            this.songName = songName;
            this.bandName = bandName;
        }

        public override string GetBandName()
        {
            return bandName;
        }
        public override string GetComponentName()
        {
            return songName;
        }
        public override void Display()
        {
            Console.WriteLine(songName + "was recorded by " + bandName);
        }
    }
}
