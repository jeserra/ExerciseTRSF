using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            var x = Console.ReadLine();
            Console.WriteLine("again give me a number");
            var y = Console.ReadLine();
            int X=int.Parse(x);
            int Y=int.Parse(y);
            Console.WriteLine($"El resultado es {Plus(X,Y)}");
            Console.ReadKey();
        }
        public static   int Plus (int X, int Y) => X + Y;
    }
}
