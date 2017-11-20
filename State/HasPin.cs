using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class HasPin : ATMState
    {

        ATMMachine atmMachine;


        public HasPin(ATMMachine newATMMachine)
        {

            atmMachine = newATMMachine;

        }

        public void insertCard()
        {

            Console.WriteLine("You already entered a card");

        }

        public void ejectCard()
        {

            Console.WriteLine("Your card is ejected");
            atmMachine.setATMState(atmMachine.getNoCardState());

        }

        public void requestCash(int cashToWithdraw)
        {

            if (cashToWithdraw > atmMachine.cashInMachine)
            {

                Console.WriteLine("You don't have that much cash available");
                Console.WriteLine("Your card is ejected");
                atmMachine.setATMState(atmMachine.getNoCardState());

            }
            else
            {

                Console.WriteLine(cashToWithdraw + " is provided by the machine");
                atmMachine.setCashInMachine(atmMachine.cashInMachine - cashToWithdraw);

                Console.WriteLine("Your card is ejected");
                atmMachine.setATMState(atmMachine.getNoCardState());

                if (atmMachine.cashInMachine <= 0)
                {

                    atmMachine.setATMState(atmMachine.getNoCashState());

                }
            }
        }

        public void insertPin(int pinEntered)
        {

            Console.WriteLine("You already entered a PIN");

        }
    }
}
