using System;

namespace AdapterDesignPattern
{
    public class EnemyTank : EnemyAttacker
    {
        
        Random generator = new Random();
        public override void FireWeapon()
        {
            double  attackDamage = generator.NextDouble()+ 1;
            
            Console.WriteLine("Enemy Tank does " + attackDamage + " Damage");
        }

        public override void DriveForward()
        {
            double movement = generator.NextDouble() + 1;
            
            Console.WriteLine("Enemy Tank moves " + movement + " spaces");
        }

        public override void AssignDriver(String driverName)
        {
            Console.WriteLine(driverName + " is driving the tank");
        }
    }
}