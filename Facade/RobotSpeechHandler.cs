using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class RobotSpeechHandler : IRobotSpeech
    {
        public void SayBye()
        {
            Console.WriteLine("Good Bye!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void SayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
