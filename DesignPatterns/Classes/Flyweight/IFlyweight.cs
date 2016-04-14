
namespace DesignPatterns.Classes.Flyweight
{
    public interface IFlyweight
    {
        string IntrinsicState { get; }
        void Operation(string value); //ExtrinsicState     
    }
}
