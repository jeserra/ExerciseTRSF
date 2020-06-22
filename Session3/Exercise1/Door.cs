using System;
namespace Exercise1{
    public class Door{
        public Door(string door){
            this.ColorDoor=door;
        }
        public string ColorDoor{get;set;}
        public void ShowData(){
            
            
            Console.WriteLine($"I am a door, my color is {ColorDoor} ");
        }
        
    }
}