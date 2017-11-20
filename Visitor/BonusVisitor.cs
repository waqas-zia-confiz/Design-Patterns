using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class BonusVisitor : IBonusVisitor
    {
        public void visitDoctor(Doctor doctor)
        {
            Console.WriteLine("Bonus: " + doctor.salary *.3);
        }

        public void visitEngineer(Engineer engineer)
        {
            Console.WriteLine("Bonus: " + engineer.salary * .4);
        }
    }
}
