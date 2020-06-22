using System;

namespace Session2E2{
    public class Student:Person{
        public Student(string Nombre,int Edad):base(Nombre,Edad){

        }
        
        public void GoToClasses(){
            Console.WriteLine("I’m going to class.");

        }

        public void ShowAge(){
            Console.WriteLine($"My age is: {this.edad} years old");
        }
    }
    
}