using System;
using System.Collections.Generic;
namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1,p2,p3;
            Service s1,s2, s3;

            p1=new Product(1,23000m,"Pc gamer",2);
            p2=new Product(2,13000m,"Pc Emprecarial",1);
            p3=new Product(3,10000.00m,"Pc Home",1);

            s1=new Service (56,500.12m,"lus",1);
            s2=new Service (323,155m,"agua",1);
            s3=new Service (312,385,"internet",1);


            

            
        }
    }
}
