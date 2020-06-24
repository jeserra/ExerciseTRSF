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
            int i=0,resultado=Numero;
            while (i==Potencia)
            {
                resultado=Numero*resultado;
                
            }
            Console.WriteLine($"el resutado es {resultado}");
            

        }
    }
}
