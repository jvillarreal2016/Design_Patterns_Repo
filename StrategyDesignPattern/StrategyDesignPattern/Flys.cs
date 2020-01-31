using System;

namespace StrategyDesignPattern
{
    public interface Flys
    {
        string fly();
    }

    class ItFlys : Flys
    {
        public string fly()
        {
            return "Flying high";
        }
    }
    class CantFly : Flys
    {
        public string fly()
        {
            return "Can't fly";
        }
    }
}