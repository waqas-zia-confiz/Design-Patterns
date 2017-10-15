using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FootballManager
    {
        private AbstractFormationBuilder builder;
        public FootballManager(AbstractFormationBuilder builder) {
            this.builder = builder;
        }
        public void BuildFormation() {
            builder.BuildDefenders();
            builder.BuildMidfielders();
            builder.BuildForwards();
        }
        public FootballFormation GetFootballFormation() {
            return builder.GetFormation();
        }
    }
}
