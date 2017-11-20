using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ATMMachine
    {

        ATMState hasCard;
        ATMState noCard;
        ATMState hasCorrectPin;
        ATMState atmOutOfMoney;

        ATMState atmState;

        public int cashInMachine { get; set; }
        public bool correctPinEntered { get; set; }

        public ATMMachine()
        {

            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);
            cashInMachine = 20000;
            atmState = noCard;

            if (cashInMachine < 0)
            {

                atmState = atmOutOfMoney;

            }

        }

        public void setATMState(ATMState newATMState)
        {

            atmState = newATMState;

        }

        public void setCashInMachine(int newCashInMachine)
        {

            cashInMachine = newCashInMachine;

        }

        public void insertCard()
        {

            atmState.insertCard();

        }

        public void ejectCard()
        {

            atmState.ejectCard();

        }

        public void requestCash(int cashToWithdraw)
        {

            atmState.requestCash(cashToWithdraw);

        }

        public void insertPin(int pinEntered)
        {

            atmState.insertPin(pinEntered);

        }

        public ATMState getYesCardState() { return hasCard; }
        public ATMState getNoCardState() { return noCard; }
        public ATMState getHasPin() { return hasCorrectPin; }
        public ATMState getNoCashState() { return atmOutOfMoney; }

    }
}
