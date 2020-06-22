using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           List <SoccerTeam> Teams=new List<SoccerTeam>();
           Teams.Add(new SoccerTeam() {Team="real madid",Ranking=1,Points=30});
          Teams.Add(new SoccerTeam () {Team="real madid",Ranking=1,Points=14});
    Teams.Add(new SoccerTeam () {Team="Barselona",Ranking=2,Points=12});
    Teams.Add(new SoccerTeam () {Team="MILAN",Ranking=3,Points=9});
    Teams.Add(new SoccerTeam () {Team="LIVERPOOL",Ranking=4,Points=6});
    Teams.Add(new SoccerTeam () {Team="ATLÉTICO",Ranking=5,Points=3});
    Teams.Add(new SoccerTeam () {Team="JUVENTUS",Ranking=6,Points=0});
        var Team2=(from t in Teams select t.Ranking);
        foreach(var item in Team2)
            Console.WriteLine( item);
    }
 }
}
