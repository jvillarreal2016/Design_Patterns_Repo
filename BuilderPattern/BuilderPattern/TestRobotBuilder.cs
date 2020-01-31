using System;

namespace BuilderPattern
{
    public class TestRobotBuilder
    {
        static void Main(string[] args)
        {
           RobotBuilder oldStyleRobot = new OldRobotBuilder();
           
           RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);
           
           robotEngineer.makeRobot();

           Robot firstRobot = robotEngineer.getRobot();
           
           Console.WriteLine("Robot Built");
           Console.WriteLine("Robot Head Type: " + firstRobot.getRobotHead());
           Console.WriteLine("Robot Torso Type: " + firstRobot.getRobotTorso());
           Console.WriteLine("Robot Arm Type: " + firstRobot.getRobotArms());
           Console.WriteLine("Robot Leg Type: " + firstRobot.getRobotLegs());
        }
    }
}