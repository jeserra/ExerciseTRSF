using System;
using System.IO;
using System.Collections.Generic;

namespace TRSFBrewery
{
    public class BreweriesCatalog :Loader
    {
        
        public List<Brewery> getListBreweries()
        {
            List<Brewery> listBreweies=new List<Brewery>{};
            
            return listBreweies;
            
            
        }
        public  void Prase()
        {
            String phat = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\breweries.csv";
            
            String[] rowBre_=load(phat);
            foreach (var item in rowBre_)
            {
                var fields =item.Split(',');
                if (fields.Length>=12)
                    getListBreweries().Add(new Brewery(){Name=fields[1],Address=fields[2],City=fields[4],State=fields[5],ZipCode=fields[6],Country=fields[7],Phone=fields[8],WebSitie=fields[9],Decription=fields[11]});
            }
        }

        
    }
}