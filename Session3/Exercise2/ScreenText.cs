using System;
using System.Linq;

namespace Exercise2
{
    public class ScreenText
    {
        public ScreenText(int x, int y, String setString)
        {
            this.X = x;
            this.Y = y;
            this.SetString = setString;
        }
        public int Y { set; get; }
        public int X { set; get; }
        public string SetString { set; get; }



        public void Dsplay()
        {
            for (int i = 0; i == X; i++){
                Console.WriteLine("#");}
            string resultado = String.Concat(Enumerable.Repeat(" ", Y));
            Console.WriteLine($"{resultado} {SetString}");

        }
    }
}