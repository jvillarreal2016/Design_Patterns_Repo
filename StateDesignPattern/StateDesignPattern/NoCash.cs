using System;

namespace StateDesignPattern
{
    public class NoCash : ATMState
    {
        ATMMachine atmMachine;

        public NoCash(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }
        
        public void InsertCard()
        {
            Console.WriteLine("We don't have money");
        }

        public void EjectCard()
        {
            Console.WriteLine("We don't have money. You didn't enter a card");
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("We don't have money");
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("We don't have money");
        }
    }
}