using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class CSharpBookPrototype : BookPrototype
    {
        public CSharpBookPrototype() {
            this.Topic = "CSharp Book";
        }
        public override BookPrototype Clone()
        {
            return this.MemberwiseClone() as CSharpBookPrototype;
        }
    }
}
