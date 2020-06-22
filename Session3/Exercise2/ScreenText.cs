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
            int i=0;

            while (i==X){
                Console.WriteLine(" 1");

            }


            string resultado = String.Concat(Enumerable.Repeat(" ", X));
            Console.WriteLine($"{resultado} {SetString} {resultado}");

        }
    }
}