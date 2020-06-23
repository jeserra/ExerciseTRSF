using System;
namespace Exercise
{
    public class Service:Concept
    {
        public Service (int i,decimal u,String property,double quantity):base (i,u)
        {
             this.Property=property;
            this.Quantity=quantity;
        }

        public String Property{private set;get;}
        public double Quantity{private set;get;}

        
        
    }
}