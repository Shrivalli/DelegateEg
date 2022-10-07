using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelLambdaEg
{
    class AnonymousMethodseg
    {
        public delegate void favcolor(string color);

        // Main method
        static public void main()
        {

            // An anonymous method with one parameter
            favcolor p = delegate (string color)
            {
                Console.WriteLine("My favorite color is: {0}",
                                                     color);
            };
            p("Green");
        }
    }
}
