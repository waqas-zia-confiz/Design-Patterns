using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IRobotMovement
    {
        void MoveForward(int distance);
        void MoveBackward(int distance);
        void MoveToLeft(int distance);
        void MoveToRight(int distance);
    }
}
