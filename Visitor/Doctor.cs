using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Doctor
    {
        public string name { get; set; }
        public string especiality { get; set; }
        public double salary { get; set; }
        public void accept(IBonusVisitor visitor)
        {
            visitor.visitDoctor(this);
        }
    }
}
