using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoCard : ATMState
    {

        ATMMachine atmMachine;


        public NoCard(ATMMachine newATMMachine)
        {

            atmMachine = newATMMachine;

        }

        public void insertCard()
        {

            Console.WriteLine("Please enter your pin");
            atmMachine.setATMState(atmMachine.getYesCardState());

        }

        public void ejectCard()
        {

            Console.WriteLine("You didn't enter a card");

        }

        public void requestCash(int cashToWithdraw)
        {

            Console.WriteLine("You have not entered your card");

        }

        public void insertPin(int pinEntered)
        {

            Console.WriteLine("You have not entered your card");

        }
    }
}
