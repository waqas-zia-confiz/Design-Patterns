using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal abstract class Character
    {
        protected char symbol;
        protected int pointSize;
        public abstract void Display(int pointSize);
    }
}
