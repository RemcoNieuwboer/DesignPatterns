
namespace DesignPatterns.Classes.Facade
{
    public class Facade
    {
        private readonly Internal _localobject = new Internal();

        public void Operation()
        {
            _localobject.GetValue();
        }
    }
}