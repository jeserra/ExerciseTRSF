using static System.Console;
using System.Collections.Generic;
using System.IO;


namespace TRSFBrewery
{
    public class BeerCatalog:Loader
    {

        public List<Beer>  SetListBeer()
        {
            List<Beer> beers1 = new List<Beer> { };
            
            return beers1;
        }

        public  void Prase()
        {
            
            string nameFile = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\beers-cleaned.csv";
            var beer = load(nameFile);

            foreach (var item in beer)
            {
                var fields = item.Split(',');
                if (fields.Length >= 10)
                    SetListBeer().Add(new Beer() { Category ="null", StyleName = fields[2], 
                    Description = fields[9], GlassType = "null", Country = "null", 
                    abv=fields[5],ibu=fields[6],srm=fields[7],upc=fields[8] });
                
            }
        }



    }

}