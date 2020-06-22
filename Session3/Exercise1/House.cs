using System;

namespace Exercise1{
    public class House{
        Door door=new Door("red");
        public House(decimal aRea){
            this.area=aRea;
        }
        public decimal area {get;set;}
        public void ShowData(){
            Console.WriteLine($"I am a house, my area is {area} m2");
            getDoor();
        }
        public void getDoor(){
            door.ShowData();
        }

    }
}