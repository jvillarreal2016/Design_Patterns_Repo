using System;
using System.Collections.Specialized;

namespace StrategyDesignPattern
{
    class StrategyDesign
    {
        static void Main(string[] args)
        {
            Animal sparky = new Dog();

            Animal tweety = new Bird();
            
            Console.WriteLine("Dog: " + sparky.TryToFly());
            Console.WriteLine("Bird: " + tweety.TryToFly());

            sparky.SetFlyingTypeAbility(new ItFlys());
            
            Console.WriteLine("Dog: " + sparky.TryToFly());
        }
    }
}