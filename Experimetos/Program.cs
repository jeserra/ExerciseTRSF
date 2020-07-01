using System;
using System.IO;


namespace Experimetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var file =File.ReadAllLines(@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\Experimetos\breweries2.csv");
            foreach (var item in file)
            {
                var row = item.Split(",");
                
                Console.WriteLine($"el id es: {row[0]}--> {row[12]}");
                
            }
        }
    }
}
