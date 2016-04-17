
namespace DesignPatterns.Classes.Factory
{
    public class Creator
    {
        public IComponent FactoryMethod(int code)
        {
            if (code < 5)
            {
               return new ComponentA(); 
            }
            else if (code >= 5 && code <10)
            {
                return new ComponentB();
            }
            else
            {
                return new DefaultComponent();
            }
        }
    }
}