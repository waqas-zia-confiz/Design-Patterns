using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class ConcreteCharacter:Character
    {
        public ConcreteCharacter(char symbol)
        {
            this.symbol = symbol;
        }

        public override void Display(int pointSize)
        {
            Console.WriteLine(symbol + ", pointsize : " + pointSize);
        }
    }
}
