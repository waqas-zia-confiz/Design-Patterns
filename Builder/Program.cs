using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFormationBuilder builder = new AttackingFormationBuilder();
            FootballManager manager = new FootballManager(builder);
            manager.BuildFormation();
            FootballFormation formation = builder.GetFormation();
            Console.WriteLine("Attacking Formation: ");
            formation.DisplayFormation();

            builder = new DefensiveFormationBuilder();
            manager = new FootballManager(builder);
            manager.BuildFormation();
            formation = builder.GetFormation();
            Console.WriteLine("Defensive Formation: ");
            formation.DisplayFormation();


        }
    }
}
