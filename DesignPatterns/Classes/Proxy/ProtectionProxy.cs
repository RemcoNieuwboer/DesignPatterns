
namespace DesignPatterns.Classes.Proxy
{
    public class ProtectionProxy : ISubject
    {
        private RealSubject _subject;
        private const string Password = "mypassword";

        public string Authenticate(string supplied)
        {
            if (supplied != Password)
            {
                return "Protection proxy: No Access";
            }
            _subject = new RealSubject();
            return "Protection proxy: Authenticated";
        }

        public string DoAction()
        {
            if (_subject == null)
            {
                return "Protection Proxy: Authenticate first";
            }
            return "Protection Proxy: Call to " + _subject.DoAction();
        }
    }
}