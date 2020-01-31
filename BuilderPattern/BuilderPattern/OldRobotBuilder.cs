namespace BuilderPattern
{
    public class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }

        public void buildRobotHead()
        {
            robot.SetRobotHead("Tin Head");
        }

        public void buildRobotTorso()
        {
            robot.SetRobotTorso("Tin Torso");
        }

        public void buildRobotArms()
        {
            robot.SetRobotArms("Blowtorch");
        }

        public void buildRobotLegs()
        {
            robot.SetRobotLegs("Roller Skates");
        }

        public Robot getRobot()
        {
            return this.robot;
        }
    }
}