using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class SongComposite:SongComponent
    {
        private List<SongComponent> songComponents = new List<SongComponent>();
        private string songCompositeName = "";

        public SongComposite(string songCompositeName)
        {
            this.songCompositeName = songCompositeName;
        }

        public override void Add(SongComponent c)
        {
            songComponents.Add(c);
        }
        public override void Remove(SongComponent c)
        {
            songComponents.Remove(c);
        }
        public override string GetComponentName()
        {
            return songCompositeName;
        }
        public override SongComponent GetComponent(int componentIndex)
        {
            if(songComponents.Count > componentIndex && componentIndex <0)
                return songComponents[componentIndex];
            return null;
        }
        public override void Display()
        {
            Console.WriteLine("Song Composite: " + songCompositeName);
            Console.WriteLine("Songs: ");
            foreach (SongComponent songComponent in songComponents) {
                songComponent.Display();
            }
        }
    }
}
