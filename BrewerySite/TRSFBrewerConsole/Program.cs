using System;
using TRSFBrewery;
using static System.Console;


namespace TRSFBrewerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StyleCatalog style=new StyleCatalog();
            var s=style.getListStyles();
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
