using System;

namespace Session2E2{
    public class Person{
        public Person(string nombre,int edad){
            this.Edad =edad;
            this.Nombre=nombre;
        }
        public string Nombre{get;set;}
        //public decimal estarura {get;set;}
        public int Edad{get;set;}

        public void hello(){
            Console.WriteLine("hello");
        }
    }
}