using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            SongComponent rock = new SongComposite("Rock Songs");
            SongComponent heyYou = new Song("Hey You", "Pink Floyd");
            SongComponent song = new Song("Coming Back To Life", "Pink Floyd");

            SongComponent darkSideOfTheMoon = new SongComposite("Dark Side of the moon");
            SongComponent run = new Song("On The Run", "Pink Floyd");
            SongComponent usAndThem = new Song("Us And Them", "PinkFloyd");

            SongComponent gfInAComma = new Song("Girl friend in a comma", "The Smiths");

            rock.Add(gfInAComma);
            rock.Add(heyYou);
            rock.Add(song);

            darkSideOfTheMoon.Add(run);
            darkSideOfTheMoon.Add(usAndThem);

            rock.Add(darkSideOfTheMoon);

            rock.Display();

        }
    }
}
