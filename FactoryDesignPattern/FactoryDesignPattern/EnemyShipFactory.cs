using System;

namespace FactoryDesignPattern
{
    public class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(String newShipType)
        {
            EnemyShip newShip = null;

            if (newShipType.Equals("U"))
            {
                return  new UFOEnemyShip();
            }
            else
            {
                if (newShipType.Equals("R"))
                {
                    return new UFOEnemyShip();
                }
                else
                {
                    if (newShipType.Equals("B"))
                    {
                        return new BigUFOEnemyShip();
                    }
                    else return null;
                }
            }
        }
    }
}