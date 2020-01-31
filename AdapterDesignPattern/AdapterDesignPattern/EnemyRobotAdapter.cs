namespace AdapterDesignPattern
{
    public class EnemyRobotAdapter : EnemyAttacker
    { 
        EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }
        
        public override void FireWeapon()
        {
            theRobot.SmashWithHands();
        }

        public override void DriveForward()
        {
            theRobot.WalkForward();
        }

        public override void AssignDriver(string driver)
        {
            theRobot.ReactToHuman(driver);
        }
    }
}