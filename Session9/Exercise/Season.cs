using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Exercise
{

    public class Season
    {
        public void ReadSeasonFromFile()
        {
            try
            {
                var FILE = File.ReadAllLines(@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Ejercios\Session9\Exercise\");
                
                foreach (var item in FILE)
                {
                    var field=item.Sp(",");
                } 
                
            }
            catch (Exception ex)
            {
                WriteLine($"Sorry, a type error arose {ex}");
            }


        }


    }



}
