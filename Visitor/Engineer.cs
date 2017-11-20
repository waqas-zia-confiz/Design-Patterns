using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Engineer
    {
        public string name { get; set; }
        public double salary { get; set; }
        public void accept(IBonusVisitor visitor) {
            visitor.visitEngineer(this);
        }
    }
}
