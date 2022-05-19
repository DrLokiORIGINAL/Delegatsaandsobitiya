using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatsaandsobitiya
{
    public delegate int CountDelegate(string message);
    class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }

        public int GetCountSymbolA(String inputString)
        {
            return inputString.Count(c => c == 'A');
        }

        public int GetCountSymbol(string inputString, char symbol)
        {
            return inputString.Count(c => c == symbol);
        }
    }
}
