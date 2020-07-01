using System;
using System.IO;
using System.Collections.Generic;
namespace TRSFBrewery
{
    public class Loader : Load
    {
        public String[] load (String filename)
        {  
        var list = File.ReadAllLines(filename);
        return list;  
        }

        


        public virtual void Prase()
        {
            throw new NotImplementedException();
        }
    }
}