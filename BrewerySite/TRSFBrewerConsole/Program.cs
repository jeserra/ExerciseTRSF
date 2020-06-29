using System;
using System.IO;

namespace TRSFBrewerConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string filename = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\styles.csv";

                var line = File.ReadAllLines(filename);
                foreach (var item in line)
                {
                    var field = item.Split(",");
                    Console.WriteLine($"######################");
                    Console.WriteLine($"#{field[0]}#{field[1]}#");
                    
                }

            }
            catch(Exception e)
            {
                Console.WriteLine($"Error {e}");
            }
        }
    }
}
