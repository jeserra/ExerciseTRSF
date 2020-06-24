using System;

namespace Exercie2
{
    class Program
    {
        public static int x=11,y=13;
        static void Main(string[] args)
        {
            Console.WriteLine($"X={x}  y={y}");
            Swap(x,y);
        }
        public static void Swap(int x , int y)
        {
            int x1,x2;
            x1=x;
            x2=y;
            x=x2;
            y=x1;
            Console.WriteLine($"X={x}  y={y}");


        }
    }
}
