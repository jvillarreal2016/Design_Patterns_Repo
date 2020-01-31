namespace StrategyDesignPattern
{
    public class Bird : Animal
    {
        public Bird()
        {
            base.SetSound("Tweet");
                
            base.flyingType = new ItFlys();
        }
    }
}