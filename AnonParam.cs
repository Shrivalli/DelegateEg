using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelLambdaEg
{
    public delegate void Show(string x);
    class AnonParam
    {
        public static void identity(Show wallet,
                              string color)
        {
            color = " Black" + color;
            wallet(color);
        }

         public static void main()
        {
              identity(delegate (string color) {
                Console.WriteLine("The color" +
                " of my Wallet is {0}", color);
            }, " and White");
        }
    }
}

