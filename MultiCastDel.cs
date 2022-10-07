using System;
using System.IO;
namespace DelLambdaEg
{
    public delegate void printmsg(string msg);
    class MultiCastDel
    {
        public static void printtoconsole(string msg)
        {
            System.Console.WriteLine("Hello "+msg);
        }

        public static void printtoFile(string msg)
        {
                FileStream fss=new FileStream("msglog.txt",FileMode.Append,FileAccess.Write);
                StreamWriter sw=new StreamWriter(fss);
                sw.WriteLine(msg+DateTime.Now);
                sw.Flush();
                fss.Close();
        }
        public static void main()
        {
            printmsg p1=new printmsg(printtoconsole);
            printmsg p2=new printmsg(printtoFile);
            printmsg p3=p1+p2; //multicast Delegate
            System.Console.WriteLine("Enter the string");
            string data=Console.ReadLine();
            p3(data);

        }

    }
}