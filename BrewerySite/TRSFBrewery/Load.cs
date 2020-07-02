using System;
namespace TRSFBrewery
{
    // Cambiar el nombre de la interface a ILoad, las interfaces deben comenzar su nombre con I por convencion. 
    public interface Load
    {
         string[] load(String filename);

        
    }
}
