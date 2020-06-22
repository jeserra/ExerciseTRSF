using System;

namespace Session2E2{
    public class Teacher:Person{
        private String Subject;
        public void setRasgos(string Nombre,int Edad){
            this.nombre=Nombre;
            this.edad=Edad;
            //this.estarura=Estarura;
        }
        public void Explain(){
            Console.WriteLine("Explanation begins");
        }

        
    }
}