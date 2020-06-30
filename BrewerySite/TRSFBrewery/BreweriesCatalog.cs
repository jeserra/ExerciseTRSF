using System;
using System.IO;
using System.Collections.Generic;

namespace TRSFBrewery
{
    public class BreweriesCatalog 
    {
        public List<Brewery> getBreweries()
        {
            List<Brewery> listBreweies=new List<Brewery>{};
            String phat = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\breweries.csv";
            Loader breweries=new Loader();
            String[] rowBre_=breweries.load(phat);
            foreach (var item in rowBre_)
            {
                var row=item.Split(',');
                listBreweies.Add(new Brewery(){Name=row[1],Address=row[2],City=row[4],State=row[5],ZipCode=row[6],Country=row[7],Phone=row[8],WebSitie=row[9],Decription=row[11]});
            }
            return listBreweies;
            
            
        }
    }
}