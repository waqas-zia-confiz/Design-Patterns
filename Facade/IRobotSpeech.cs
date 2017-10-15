using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IRobotSpeech
    {
        void SayHello();
        void SayMessage(string message);
        void SayBye();
    }
}
