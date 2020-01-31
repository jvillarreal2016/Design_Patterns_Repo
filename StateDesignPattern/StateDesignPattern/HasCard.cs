using System;
using System.Runtime.ConstrainedExecution;

namespace StateDesignPattern
{
    public class HasCard : ATMState
    {
        ATMMachine atmMachine;

        public HasCard(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("You can't enter more than one card");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejected");
            atmMachine.SetATMState(atmMachine.GetNoCardState());
        }

        public void InsertPin(int pinEntered)
        {
            if (pinEntered == 1234)
            {
                Console.WriteLine("Correct PIN");
                atmMachine.correctPinEntered = true;
                atmMachine.SetATMState(atmMachine.GetHasPin());
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                atmMachine.correctPinEntered = false;
                Console.WriteLine("Card Ejected");
                atmMachine.SetATMState(atmMachine.GetNoCardState());
            }
        }

        public void RequestCash(int cashToWithdraw)
        {
            Console.WriteLine("Enter PIN First");
        }
    }
}