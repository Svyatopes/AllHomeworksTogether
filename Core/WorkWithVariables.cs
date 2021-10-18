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

        public static void ChangeSign(ref int variable)
        {
            variable = -variable;
        }

        public static void MakePositive(ref int variable)
        {
            if (variable < 0)
                ChangeSign(ref variable);
        }
    }
}
