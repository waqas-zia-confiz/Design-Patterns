﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoCash : ATMState
    {

        ATMMachine atmMachine;


        public NoCash(ATMMachine newATMMachine)
        {

            atmMachine = newATMMachine;

        }

        public void insertCard()
        {

            Console.WriteLine("We don't have any money");
            Console.WriteLine("Your card is ejected");

        }

        public void ejectCard()
        {

            Console.WriteLine("We don't have any money");
            Console.WriteLine("There is no card to eject");

        }

        public void requestCash(int cashToWithdraw)
        {

            Console.WriteLine("We don't have any money");

        }

        public void insertPin(int pinEntered)
        {

            Console.WriteLine("We don't have any money");

        }
    }
}
