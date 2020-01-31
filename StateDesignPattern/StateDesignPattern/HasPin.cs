using System;

namespace StateDesignPattern
{
    public class HasPin : ATMState
    {
        ATMMachine atmMachine;

        public HasPin(ATMMachine newATMMachine)
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
            Console.WriteLine("Already Entered PIN");
        }

        public void RequestCash(int cashToWithdraw)
        {
            if (cashToWithdraw > atmMachine.CashInMachine())
            {
                Console.WriteLine("Don't have that cash");
                Console.WriteLine("Card Ejected");
                atmMachine.SetATMState(atmMachine.GetNoCardState());
            }
            else
            {
                Console.WriteLine( cashToWithdraw + " is provided by the machine");
                atmMachine.SetCashInMachine(atmMachine.CashInMachine() - cashToWithdraw);
                Console.WriteLine("Card Ejected");
                atmMachine.SetATMState(atmMachine.GetNoCardState());

                if (atmMachine.CashInMachine() <= 0)
                {
                    atmMachine.SetATMState(atmMachine.GetNoCardState());
                }
                
            }
        }
    }
}