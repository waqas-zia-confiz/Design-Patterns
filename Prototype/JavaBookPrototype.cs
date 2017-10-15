using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class JavaBookPrototype : BookPrototype
    {
        public JavaBookPrototype() {
            this.Topic = "Java Book";
        }
        public override BookPrototype Clone()
        {
            return this.MemberwiseClone() as JavaBookPrototype;
        }
    }
}
