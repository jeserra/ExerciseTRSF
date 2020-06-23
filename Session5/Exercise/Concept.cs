using System ;
namespace Exercise
{
    public class Concept:ITaxable
    {
        public Concept(int id,decimal unitPrice){
            this.ID=id;
            this.UnitPrice=unitPrice;
        }
        public int ID {private set ;get;}
        public decimal UnitPrice{private set; get;}

        public decimal CalcTax()
        {
            throw new NotImplementedException();
        }
    }

    public interface ITaxable
    {
        public decimal CalcTax();
    }
}