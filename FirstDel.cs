using System;

namespace DelLambdaEg
{
    
    class FirstDel
    {
        //delegate declaration
        public delegate int deladd(int x, int y);
        public delegate void delmsg(string a);

        public static int add(int a, int b)
        {
            return a+b;
        }

        public static int mul(int a, int b)
        {
            return a*b;
        }

        public void message(string name)
        {
            System.Console.WriteLine("Welcome "+name);
        }
        public static void main()
        {
            FirstDel obj=new FirstDel();
               // int result=add(10,20);
               deladd d1=new deladd(add);
               deladd d2=new deladd(mul);
               delmsg d3=new delmsg(obj.message);
               int result=d1(10,20);
               int prod=d2(4,5);
                System.Console.WriteLine(result);
                System.Console.WriteLine(prod);
                d3("Shyam");
        }
    }
}