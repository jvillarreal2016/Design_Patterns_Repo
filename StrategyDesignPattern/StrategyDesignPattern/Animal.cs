using System;

namespace StrategyDesignPattern
{
    public class Animal
    {
        private string name;
        private double height;
        private int weight;
        private string favFood;
        private double speed;
        private string sound;

        public Flys flyingType;

        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetName()
        {
            return name;
        }

        public void SetHeight(double newHeight)
        {
            height = newHeight;
        }
        public double GetHeight()
        {
            return height;
        }

        public void SetWeight(int newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
            else
            {
                Console.Write("Weight must be bigger than 0");
            }
        }
        public double GetWeight()
        {
            return weight;
        }

        public void SetFavFood(string newFavFood)
        {
            favFood = newFavFood;
        }
        public string GetFavFood()
        {
                return favFood;
        }

        public void SetSpeed(double newSpeed)
        {
            speed = newSpeed;
        }
        public double GetSpeed()
        {
            return speed;
        }

        public void SetSound(string newSound)
        {
            sound = newSound;
        }

        public string GetSound()
        {
            return sound;
        }

        public string TryToFly()
        {
            return flyingType.fly();
        }

        public void SetFlyingTypeAbility(Flys newFlyingType)
        {
            flyingType = newFlyingType;
        }
    }
}