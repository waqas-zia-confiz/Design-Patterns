using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DefensiveFormationBuilder : AbstractFormationBuilder
    {
        public override void BuildDefenders() {
            formation.Defenders = 4;
        }
        public override void BuildMidfielders()
        {
            formation.Midfielders = 6;
        }
        public override void BuildForwards()
        {
            formation.Forwards = 0;
        }
    }
}
