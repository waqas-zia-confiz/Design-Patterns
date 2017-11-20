using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class NumberExpression : IExpression
    {
        int number;
        public NumberExpression(int i)
        {
            number = i;
        }

        int IExpression.Interpret()
        {
            return number;
        }
    }
}
