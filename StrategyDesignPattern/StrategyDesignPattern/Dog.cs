namespace StrategyDesignPattern
{
    using System;
    using System.Runtime.InteropServices.ComTypes;
    using System.Transactions;

        public class Dog : Animal
        {
            public Dog()
            {
                base.SetSound("Bark");
                
                base.flyingType = new CantFly();
            }

            public void DigHole()
            {
                Console.WriteLine("Dug a hole");
            }
            
            
        }
        
}
