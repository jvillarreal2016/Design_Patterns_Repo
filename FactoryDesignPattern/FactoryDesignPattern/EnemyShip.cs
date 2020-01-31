using System;

namespace FactoryDesignPattern
{
    public abstract class EnemyShip
    {
        private string name;
        private double amtDamage;

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public double GetDamage()
        {
            return amtDamage;
        }

        public void SetDamage(double newDamage)
        {
            amtDamage = newDamage;
        }

        public void FollowHeroShip()
        {
            Console.Write(GetName() + " is following the hero ");
        }

        public void DisplayEnenmyShip()
        {
            Console.WriteLine(GetName() + " is on the screen ");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine("\n" + GetName() + " attacks and does " + GetDamage());
        }
        
    }
}