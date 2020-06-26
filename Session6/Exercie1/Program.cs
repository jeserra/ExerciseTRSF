using System;
using System.Collections.Generic;
using static System.Console;


namespace Exercie1
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string R { get; set; }
        public string G { get; set; }
        public string B { get; set; }
        public void Show()
        {
            WriteLine($"the point is {X} and {Y}");
            WriteLine($"and the colors are, {R}, {G}, {B}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.B = "blue";
            point1.G = "Green";
            point1.G = "Red";
            point1.X = 16;
            point1.Y = 10;

            WriteLine("Give me X");
            int x = int.Parse(ReadLine());
            WriteLine("Give me Y");
            int y = int.Parse(ReadLine());

            Point point = new Point();
            point.B = "blue";
            point.G = "Green";
            point.G = "Red";
            point1.X = x;
            point1.Y = y;

            point1.Show();
            point.Show();
            ReadKey();
        }
    }
}
