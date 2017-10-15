using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class RobotFacade
    {
        private IRobotBoot bootHandler;
        private IRobotMovement movementHandler;
        private IRobotSpeech speechHandler;

        public RobotFacade()
        {
            this.bootHandler = new RobotBootHandler();
            this.movementHandler = new RobotMovementHandler();
            this.speechHandler = new RobotSpeechHandler();
        }

        public void start()
        {
            bootHandler.start();
            speechHandler.SayHello();
        }

        public void stop()
        {
            speechHandler.SayBye();
            bootHandler.stop();
        }
        public void SpeakMessage(string message)
        {
            speechHandler.SayMessage(message);
        }
        public void MoveBackward(int distance)
        {
            movementHandler.MoveBackward(distance);
        }

        public void MoveForward(int distance)
        {
            movementHandler.MoveForward(distance);
        }

        public void MoveToLeft(int distance)
        {
            movementHandler.MoveToLeft(distance);
        }

        public void MoveToRight(int distance)
        {
            movementHandler.MoveToRight(distance);
        }

        public void MoveTopRight(int distance) {
            movementHandler.MoveForward(distance);
            movementHandler.MoveToRight(distance);
        }
        public void MoveTopLeft(int distance)
        {
            movementHandler.MoveForward(distance);
            movementHandler.MoveToLeft(distance);
        }
        public void MoveBottomRight(int distance)
        {
            movementHandler.MoveBackward(distance);
            movementHandler.MoveToRight(distance);
        }
        public void MoveBottomLeft(int distance)
        {
            movementHandler.MoveBackward(distance);
            movementHandler.MoveToLeft(distance);
        }
    }
}
