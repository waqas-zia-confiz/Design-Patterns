using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class AttackingFormationBuilder : AbstractFormationBuilder
    {
        public override void BuildDefenders()
        {
            formation.Defenders = 4;
        }
        public override void BuildMidfielders()
        {
            formation.Midfielders = 3;
        }
        public override void BuildForwards()
        {
            formation.Forwards = 3;
        }
    }
}
