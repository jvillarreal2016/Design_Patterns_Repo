using System;

namespace BuilderPattern
{
    public class Robot : RobotPlan
    {

        private String robotHead;
        private String robotTorso;
        private String robotArms;
        private String robotLegs;
        
        public void SetRobotHead(string head)
        {
            robotHead = head;
        }

        public String getRobotHead()
        {
            return robotHead;
        }

        public void SetRobotTorso(string torso)
        {
            robotTorso = torso;
        }

        public String getRobotTorso()
        {
            return robotTorso;
        }

        public void SetRobotArms(string arms)
        {
            robotArms = arms;
        }

        public String getRobotArms()
        {
            return robotArms;
        }

        public void SetRobotLegs(string legs)
        {
            robotLegs = legs;
        }

        public String getRobotLegs()
        {
            return robotLegs;
        }
    }
}