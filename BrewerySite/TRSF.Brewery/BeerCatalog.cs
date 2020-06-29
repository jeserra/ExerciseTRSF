using static System.Console;
using System.Collections.Generic;
using System.IO;


namespace TRSF.Brewery
{
    public class BeerCatalog : Load
    {
       

        //string filename=@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\beers-cleaned.csv";


        public void load(string filename)
        {
             List<Beer> Beers=new List<Beer>{};
            try
            {
                var line = File.ReadAllLines(filename);
                foreach (var item in line)
                {
                    var field = item.Split(',');

                    //Beers.Add(item: new Beer(){field[0]}); 
                }
            }catch(FileLoadException e)
            {
                WriteLine($"sorry we found a type error {e}");
            }
        }
    }

}