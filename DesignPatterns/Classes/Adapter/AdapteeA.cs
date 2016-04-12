using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Classes.Adapter
{
    public class AdapteeA : IAdaptee
    {
        public double SpecificRequest(double a, double b) {
            return a / b;
        }
    }
}