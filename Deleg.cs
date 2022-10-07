using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelLambdaEg
{
    class Deleg
    {
        delegate bool D();
        delegate bool D2(int i);

        class Test
        {
            D del;
            D2 del2;

            public void TestMethod(int input)
            {
                int j = 0;
                // Initialize the delegates with lambda expressions.
                // Note access to 2 outer variables.
                // del will be invoked within this method.
                del = () => { j = 10; return j > input; };

                // del2 will be invoked after TestMethod goes out of scope.
                del2 = (x) => { return x == j; };

                // Demonstrate value of j:            
                // The delegate has not been invoked yet.
                Console.WriteLine("j = {0}", j);        // Invoke the delegate.
                bool boolResult = del();

                Console.WriteLine("j = {0}. b = {1}", j, boolResult);
            }

            static void main()
            {
                Test test = new Test();
                test.TestMethod(5);

                // Prove that del2 still has a copy of
                // local variable j from TestMethod.
                bool result = test.del2(10);

                Console.WriteLine(result);
            }
        }
    }
}
