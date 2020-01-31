using  System;

namespace AdapterDesignPattern
{
    public abstract class EnemyAttacker
    {
        public abstract void FireWeapon();
        public abstract void DriveForward();
        public abstract void AssignDriver(String driver);
    }
}