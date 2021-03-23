using System;

namespace Swap
{
    class Program
    {
        public static void Replace(int a, int b)
        {

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The value of the 1st variable: " + a + "\n" + "The value of the 2nd variable: " + b);
        }


        static void Main(string[] args)
        {
            int a,b;
            Console.Write("Please give a number as 1st variable: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please give a number as 2nd variable: ");
            b = Convert.ToInt32(Console.ReadLine());

            Replace(a, b);



        }
    }
}
