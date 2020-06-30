using static System.Console;
using System.Collections.Generic;
using System.IO;


namespace TRSFBrewery
{
    public class BeerCatalog
    {
        public List<Beer> GetBeers()
        {
            List<Beer> beers1 = new List<Beer> { };

            string nameFile = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\beers-cleaned.csv";
            Loader loaderBeer = new Loader();
            var beer = loaderBeer.load(nameFile);
            foreach (var item in beer)
            {
                var beers = item.Split(',');
                beers1.Add(new Beer() { Category = beers[0], StyleName = beers[1], Description = beers[2], GlassType = beers[3], Country = beers[4] });

            }

            return beers1;


        }

    }

}