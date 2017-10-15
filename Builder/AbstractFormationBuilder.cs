using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class AbstractFormationBuilder
    {
        protected FootballFormation formation;
        public AbstractFormationBuilder() {
            formation = new FootballFormation();
        }
        public FootballFormation GetFormation() {
            return formation;
        }
        public abstract void BuildDefenders();

        public abstract void BuildMidfielders();

        public abstract void BuildForwards();

    }
}
