using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes.Adapter
{
    public interface IAdapter
    {
        string Request(int a, int b);
    }
}
