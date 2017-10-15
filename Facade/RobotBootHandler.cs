using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class RobotBootHandler : IRobotBoot
    {
        public void start()
        {
            Console.WriteLine("Robot is starting");
        }

        public void stop()
        {
            Console.WriteLine("Robot is stopping");
        }
    }
}
