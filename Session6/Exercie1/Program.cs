using System;
using System.Collections.Generic;
using static System.Console;


namespace Exercie1
{

//[System.Flags]
    enum Colors 
    {
        none = 0,
        red =1,
        green=2,
        blue=4
    }
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string R { get; set; }
        public string G { get; set; }
        public string B { get; set; }
        public Colors Color {get;set;}
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
            
            
            WriteLine(Colors.green);
            
            WriteLine((int)Colors.green);

            Point point_1 = new Point();
            point_1.Color=Colors.blue | Colors.red ;
            WriteLine(point_1.Color);
            WriteLine((int)point_1.Color);

            point_1.B = "blue";
            point_1.G = "Green";
            point_1.R = "Red";
            point_1.X = 16;
            point_1.Y = 10;

            Point point2 = new Point();
            point2.B = "blue";
            point2.G = "Green";
            point2.R = "Red";
            point2.X = 5;
            point2.Y = 5;

            WriteLine("Give me X");
            int x = int.Parse(ReadLine());
            WriteLine("Give me Y");
            int y = int.Parse(ReadLine());

            Point point = new Point();
            point.B = "blue";
            point.G = "Green";
            point.R = "Red";
            point_1.X = x;
            point_1.Y = y;

            point_1.Show();
            point2.Show();
            point.Show();
            ReadKey();
        }
    }
}
