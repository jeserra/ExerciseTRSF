using System;
namespace Exercise
{
    public class Product:Concept,ITaxable
    {
        public Product (int i,decimal u,String property,double quantity):base (i,u)
        {
            this.Property=property;
            this.Quantity=quantity;
        }
        public String Property{private set;get;}
        public double Quantity{private set;get;}

        public decimal CalcTax()
        {
            
            return UnitPrice*1.16m;
        }
    }
}