
namespace DesignPatterns.Classes.Bridge
{
    public class Abstraction
    {
        private readonly IBridge _bridge;
        public Abstraction(IBridge implementation)
        {
            _bridge = implementation;
        }

        public string Operation()
        {
            return _bridge.Operation();
        }
    }
}