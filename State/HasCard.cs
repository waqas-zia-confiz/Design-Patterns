using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class HasCard : ATMState
    {

        ATMMachine atmMachine;


        public HasCard(ATMMachine newATMMachine)
        {

            atmMachine = newATMMachine;

        }

        public void insertCard()
        {

            Console.WriteLine("You can only insert one card at a time");

        }

        public void ejectCard()
        {

            Console.WriteLine("Your card is ejected");
            atmMachine.setATMState(atmMachine.getNoCardState());

        }

        public void requestCash(int cashToWithdraw)
        {

            Console.WriteLine("You have not entered your PIN");


        }

        public void insertPin(int pinEntered)
        {

            if (pinEntered == 1234)
            {

                Console.WriteLine("You entered the correct PIN");
                atmMachine.correctPinEntered = true;
                atmMachine.setATMState(atmMachine.getHasPin());

            }
            else
            {

                Console.WriteLine("You entered the wrong PIN");
                atmMachine.correctPinEntered = false;
                Console.WriteLine("Your card is ejected");
                atmMachine.setATMState(atmMachine.getNoCardState());

            }
        }
    }
}
