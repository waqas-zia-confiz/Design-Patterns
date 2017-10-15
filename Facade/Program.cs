using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotFacade facade = new RobotFacade();
            facade.start();
            facade.MoveForward(2);
            facade.MoveBackward(2);
            facade.MoveToRight(2);
            facade.MoveToLeft(2);

            facade.SpeakMessage("I'm here");

            facade.MoveBottomLeft(2);
            facade.MoveBottomRight(2);
            facade.MoveTopRight(2);
            facade.MoveTopLeft(2);

            facade.stop();
        }
    }
}
