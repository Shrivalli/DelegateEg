using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelLambdaEg
{
    class FuncDeleg
    {
        public static void main()
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            // Debug.Write(square(4));

            Func<int, int, int> Adddel = (int a, int b) => a + b;
            Console.WriteLine(Adddel(5, 6));

            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(5,"welcome"));
        }
    }
}
