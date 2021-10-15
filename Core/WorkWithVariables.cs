using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class WorkWithVariables
    {
        public static void Swap<T>(ref T firstVariable, ref T secondVariable)
        {
            T _ = firstVariable;
            firstVariable = secondVariable;
            secondVariable = _;
        }
    }
}
