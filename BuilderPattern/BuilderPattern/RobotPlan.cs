using System;

namespace BuilderPattern
{
    public interface RobotPlan
    {
        public void SetRobotHead(String head);
        public void SetRobotTorso(String torso);
        public void SetRobotArms(String arms);
        public void SetRobotLegs(String legs);
        
    }
}