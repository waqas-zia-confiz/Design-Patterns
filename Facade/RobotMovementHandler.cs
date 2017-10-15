using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class RobotMovementHandler : IRobotMovement
    {
        public void MoveBackward(int distance)
        {
            Console.WriteLine("Taking {0} Steps Backward", distance);
        }

        public void MoveForward(int distance)
        {
            Console.WriteLine("Taking {0} Steps Forward", distance);
        }

        public void MoveToLeft(int distance)
        {
            Console.WriteLine("Taking {0} Steps Left", distance);
        }

        public void MoveToRight(int distance)
        {
            Console.WriteLine("Taking {0} Steps Right", distance);
        }
    }
}
