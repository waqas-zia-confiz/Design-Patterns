using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request1 = new Request(Operation.ADDITION, 2, 2);
            Request request2 = new Request(Operation.MULTIPLICATION, 2, 2);
            Request request3 = new Request(Operation.DIVISION, 2, 2);
            Request request4 = new Request(Operation.SUBTRACTION, 2, 2);

            Handler additionHandler = new AdditionHandler();
            Handler subtractionHandler = new SubtractionHandler();
            Handler divisionHandler = new DivisionHandler();
            Handler multiplicationHandler = new MultiplicationHandler();

            additionHandler.SetSuccessor(subtractionHandler);
            subtractionHandler.SetSuccessor(divisionHandler);
            divisionHandler.SetSuccessor(multiplicationHandler);

            additionHandler.HandleRequest(request1);
            additionHandler.HandleRequest(request2);
            additionHandler.HandleRequest(request3);
            additionHandler.HandleRequest(request4);

        }
    }
}
