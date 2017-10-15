using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Request
    {
        private Operation _operation;
        private int _numberOne;
        private int _numberTwo;
        public Request(Operation operation, int numberOne, int numberTwo)
        {
            _operation = operation;
            _numberOne = numberOne;
            _numberTwo = numberTwo;
        }

        public int NumberOne { get => _numberOne; }
        public int NumberTwo { get => _numberTwo; }
        public Operation GetOperation { get => _operation; }
    }
}
