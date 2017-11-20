using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            BonusVisitor visitor = new BonusVisitor();

            Engineer engineer = new Engineer();
            engineer.name = "Waqas";
            engineer.salary = 10000;
            Doctor doctor = new Doctor();
            doctor.name = "Maham";
            doctor.salary = 10000;

            doctor.accept(visitor);
            engineer.accept(visitor);

        }
    }
}
