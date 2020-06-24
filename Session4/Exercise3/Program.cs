using System;

namespace Exercise3
{
    class Program
    {
         
        static void Main(string[] args)
        {
            int numero=2 , potencia=3;
            Potencia(numero,potencia);
        }

        public static void Potencia(int Numero,int Potencia)
        {
            int i=1,resultado=1;
            while (i<=Potencia)
            {
               
                resultado*=Numero;

                 i++;
            }
            Console.WriteLine($"el resutado es {resultado}");
            

        }
    }
}
