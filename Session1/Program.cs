using System;


public class Program
    {
        static void Main(string[] args){
             Excercise1();
             Console.Read();
        }

        public static void Excercise1(){
            int N1,N2;
            Console.WriteLine("Give me the first number");
            var n1=Console.ReadLine();

            Console.WriteLine("Give me the second number");
            var n2=Console.ReadLine();

            N1=int.Parse(n1);
            N2=int.Parse(n2);

            var D=N1-N2;
           // var VA = Math.Abs(D);
            var VA = Math.Abs(N1-N2);
            if (N1<N2){
                Console.WriteLine($"the result is {2*VA}");
            }
            else{
                Console.WriteLine($"the result is {VA}");
                }
      }
      public static void Excercise2(){
          for (int i=1;i==99;i++){
              Console.WriteLine(i);
          }
        }

        public static void Excercise3(){
            int N1,N2;
            Console.WriteLine("Give me the first number");
            var n1=Console.ReadLine();

            Console.WriteLine("Give me the second number");
            var n2=Console.ReadLine();

            N1=int.Parse(n1);
            N2=int.Parse(n2);

            var D=N1-N2;
            
            if (N1<N2){
                var VA = Math.Abs(D);
                Console.WriteLine($"the result is {2*VA}");
            }
            else{
                Console.WriteLine($"the result is {D}");
                }
      }
    }