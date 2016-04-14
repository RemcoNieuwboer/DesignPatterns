
namespace DesignPatterns.Classes.Flyweight
{
    public class Flyweight : IFlyweight
    {
        public string IntrinsicState { get; private set; }

        public void Operation(string value)
        {
            IntrinsicState = value;
        }
    }
}