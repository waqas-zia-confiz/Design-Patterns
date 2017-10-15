using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class UnsharedCharacter : Character
    {
        public UnsharedCharacter(char symbol, int pointSize)
        {
            this.symbol = symbol;
            this.pointSize = pointSize;
        }

        public override void Display(int pointSize=0)
        {
            Console.WriteLine(symbol + ", pointsize : " + this.pointSize);
        }
    }
}
