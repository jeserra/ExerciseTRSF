using System;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r=new Rectangle();
            int Area= r.area(4,2);
            int Perimetro=r.perimeter(4,2);
            Console.WriteLine($"El area es {Area}  y el Perimetro es {Perimetro}");
        }
    }
}
