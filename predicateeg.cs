using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://zetcode.com/csharp/predicate/

namespace DelLambdaEg
{
    class predicateeg
    {
        public static void main()
        {
            var data = new List<int> { 1, -2, 3, 0, 2, -1 };

            //Predicate<int> isPositive = delegate (int val) { return val > 0; };
            //var filtered = data.FindAll(isPositive);

            //Console.WriteLine(string.Join(",", filtered));

            var predicate = new Predicate<int>(isPositive);
            var filtered = data.FindAll(predicate);

            Console.WriteLine(string.Join(",", filtered));
            bool isPositive(int val)
            {
                return val > 0;
            }

            //Predicate with Lambda
            var words = new List<string> { "falcon", "wood", "tree",
    "rock", "cloud", "rain" };

            Predicate<string> hasFourChars = word => word.Length == 4;

            var words2 = words.FindAll(hasFourChars);
            Console.WriteLine(string.Join(',', words2));

            //Exists example
            var words3 = new List<string> { "sky", "", "club", "spy", "silk", "summer",
        "war", "cup", "cloud", "coin", "small", "terse", "",
        "snow", "snail", "see"};

            Predicate<string> pred = String.IsNullOrEmpty;

            if (words3.Exists(pred))
            {
                Console.WriteLine("There is an empty string");
            }
            else
            {
                Console.WriteLine("There is no empty string");
            }

            
        }
    }
}
