using System;
using System.IO;
namespace TRSFBrewery
{
    public class Loader : Load
    {
        public String[] load (String filename)
        {  
        var list = File.ReadAllLines(filename);
        return list;  
        }
    }
}