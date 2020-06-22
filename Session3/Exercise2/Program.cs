using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CenteredText centered=new CenteredText(5,10,"Hola A todos");
            centered.Dsplay();
            FramedText cuadro = new FramedText(5,32,"este es un mensaje");
            cuadro.Diplay();
            ScreenText screen=new ScreenText(5,10,"esto es el cuerpo");
            screen.Dsplay();

            
        }
    }
}
