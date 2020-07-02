using System;
using System.Collections.Generic;

namespace TRSFBrewery
{
    public class StyleCatalog : Loader
    {
        
        /// <summary>
        /// Transforma una la lineas en objetos 
        /// </summary>
        public Style Parse(String[] Item)
        {
            Style style=new Style();
            
                if (Item.Length >= 3)
                {
                     
                    style.Id=/*int.Parse(Item[0]);*/Item[0];
                    style.NameStyle=Item[3];
                }
                // Si la linea no trae informacion, el metodo debe regresar un nulo, no un elemento vacio.



            return style;

        }

        /// <summary>
        /// llena la lista de estilos con los datos del archivo estilo 
        /// </summary>   
        public List<Style> getListStyles()
        {
            List<Style> Styles = new List<Style> { };
            String phat = @"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Repocitorio\ExerciseTRSF\BrewerySite\Files\styles.csv";

            String[] rowsStyles = load(phat);
            foreach (var item in rowsStyles)
            {
                var fields = item.Split(',');
                var Style = Parse(fields);
                
                // validar si el estilo es nulo, si lo es, no agregar a la lista. 
                Styles.Add(Style);
            }

            return Styles;


        }





    }
}
