using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelLambdaEg
{
    class Actiondel
    {
        public static void main()
        {
            Action act = () =>
            {
                Console.WriteLine("No Parameter");
            };

            Action<int> actWithOneParameter = (arg1) =>
            {
                Console.WriteLine("Par: " + arg1);
            };

            Action<int, int> actWithTwoParameter = (arg1, arg2) =>
            {
                Console.WriteLine("Par1: " + arg1 + ", Par2: " + arg2);
            };

            act();
            actWithOneParameter(1);
            actWithTwoParameter(1, 2);
        }
    }
}
