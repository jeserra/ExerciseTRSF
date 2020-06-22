using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise{
    
    public class Season{

      List <SoccerTeam> Teams ;
        public void getList()
    {
    Teams.Add(new SoccerTeam () {Team="real madid",Ranking=1,Points=14});
    Teams.Add(new SoccerTeam () {Team="Barselona",Ranking=2,Points=12});
    Teams.Add(new SoccerTeam () {Team="MILAN",Ranking=3,Points=9});
    Teams.Add(new SoccerTeam () {Team="LIVERPOOL",Ranking=4,Points=6});
    Teams.Add(new SoccerTeam () {Team="ATLÉTICO",Ranking=5,Points=3});
    Teams.Add(new SoccerTeam () {Team="JUVENTUS",Ranking=6,Points=0});
    }  

    
public void getMach(){
    
    var Team=(from t in Teams select t.Ranking);
    foreach(var item in Team1)
            
    }
    
    
  

}
private void  ReadSeasonFromFile(){
    try
{
var FILE = File.ReadAllLines(@"D:\User\Vicente\Proyectos\Cursos de Programacion\Curso de C#\Ejercios\Session9\Exercise\List.csv");
}catch(Exception ex)
{
    Console.WriteLine($"Sorry, a type error arose {ex}");
}


}
        
        
    }
}