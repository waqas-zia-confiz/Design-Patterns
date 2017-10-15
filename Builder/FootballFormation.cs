using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FootballFormation
    {
        private int keeper = 1;
        private int defenders;
        private int midfielders;
        private int forwards;

        public int Defenders { get => defenders; set => defenders = value; }
        public int Midfielders { get => midfielders; set => midfielders = value; }
        public int Forwards { get => forwards; set => forwards = value; }
        public void DisplayFormation()
        {
            Console.WriteLine("Formation");
            Console.WriteLine("Keepr: " + keeper);
            Console.WriteLine("Defenders: " + Defenders);
            Console.WriteLine("Midfielers: " + Midfielders);
            Console.WriteLine("Forwards: " + Forwards);
        }
    }
}
