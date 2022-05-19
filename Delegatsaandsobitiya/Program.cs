using System;

namespace Delegatsaandsobitiya
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();

            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;

            string testString = "LAMPADA";

            Console.WriteLine("Общее количество символов: {0}", TestDelegate(d1, testString));
            Console.WriteLine("Общее количество символов: {0}", TestDelegate(d2, testString));

        }

        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
    }
}
