using System;

namespace AdapterDesignPattern
{
    public class EnemyRobot
    {
        Random generator = new Random();

        public void SmashWithHands()
        {
            double attackDamage = generator.NextDouble() + 1;
            
            Console.WriteLine("Enemy Robot Causes " + attackDamage + " damage with its hands");
        }

        public void WalkForward()
        {
            double movement = generator.NextDouble() + 1;
            
            Console.WriteLine("Enemy Robot Walks Forward" + movement + " Spaces");
        }

        public void ReactToHuman(String driveName)
        {
            Console.WriteLine("Enemy Robot Tramps on " + driveName);
        }
    }
}