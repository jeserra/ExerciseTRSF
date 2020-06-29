using System;
using System.IO;
using System.Collections.Generic;

namespace TRSF.Brewery
{
    public class BreweriesCatalog : Load
    {
        public void load(string filename)
        {
            List<Brewery> brewery = new List<Brewery>{};
            try
            {
                var line=File.ReadAllLines(filename);
                foreach (var item in line)
                {
                    
                    var row =item.Split(',');
                    // brewery.Add( new Brewery(){row[0]}); 
                }
            }
            catch(FileLoadException e)
            {
                Console.WriteLine($"sorry we found a type error {e}");
            }
            
        }
    }
}