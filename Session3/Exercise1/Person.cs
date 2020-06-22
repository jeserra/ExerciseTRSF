using System;
namespace Exercise1{
    public class Person{
        public Person(string name){
            this.Name=name;
        }

        public string Name {get; set;}
         
            public void ShowData(){
            Console.WriteLine(Name);
            House house=new House(500m);
            house.ShowData();
            
        }
    }
}