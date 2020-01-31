using System;

namespace FactoryDesignPattern
{
    public partial class EnemyShipTesting
    {
        static void Main(string[] args)
        {
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            EnemyShip theEnemy = null;

            string readLine;
            readLine = Console.ReadLine();
            //Scanner userInput = new Scanner(System.in);

            Console.WriteLine("What type of ship? (U / R / B)");

            
                String typeOfShip = readLine;

                    theEnemy = shipFactory.makeEnemyShip(typeOfShip);
                
                if (theEnemy != null)
                {
                    DoStuffEnemy(theEnemy);
                }
                else
                {
                    Console.WriteLine("Enter U / R / B");
                }
        }

        public static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnenmyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EnemyShipShoots();
        }
    }
}