using System;

namespace Exercise5
{
    class Program
    {
        static string  sentence = "Tomato";
        static void Main(string[] args)
        {
            

           Console.WriteLine( ChangeChar(sentence, 5, "a"));

        }

        public static String ChangeChar(String Txt ,int x, String lyrics)
        {
            return Txt.Insert(x,lyrics);
        }  
    }
}
