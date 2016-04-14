
namespace DesignPatterns.Classes.Adapter
{
    public class AdapteeB : IAdaptee
    {
        public double SpecificRequest(double a, double b)
        {
            return a + b;
        }
    }
}