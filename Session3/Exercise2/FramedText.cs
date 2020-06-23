using System;
using System.Linq;

namespace Exercise2
{
    public class FramedText
    {
        int x,y;
        String M;
        public FramedText(String sStrtin )
        {
            this.x=35;
            this.y=5;
            this.M=sStrtin;
        }
        public void Diplay()
        {
            string resultado = String.Concat(Enumerable.Repeat(" ",x ));
            string linea = String.Concat(Enumerable.Repeat("#",y ));
            Console.WriteLine(linea);
            Console.WriteLine($"#{resultado} {M} {resultado}#");
            Console.WriteLine(linea);
        }
    }
}