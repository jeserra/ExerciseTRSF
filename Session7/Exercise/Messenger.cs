using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace Exercise
{
public  class Messenger{
     
    public  void MailBox()
    {
        List<Email> Box =new List<Email>();
        Box.Add(new Email(){Date="26/06/2020",From="eduardo45123@hotmail.com",To="juan12mar@oulook.com",message="Hola buenas tardesa revicion de rutina "});
        Box.Add(new Email(){Date="23/06/2020",From="chente31209@hotmail.com",To="elmagoqwe12@gmail.com",message="envio de libros y cursos  "});
        Box.Add(new Email(){Date="2/04/2020",From="maquinadefuego501@gmail.com",To="rgt127ehd@itszo.edu.com",message="Correcion de travajps  "});
        Box.Add(new Email(){Date="1/1/2020",From="juan12mar@oulook.com",To="eduardo45123@hotmail.com",message="Confirmacion de Mensaje"});
        foreach(var item in Box)
        {
            WriteLine(item.Date);
            WriteLine(item.From);
            WriteLine(item.To);
            WriteLine(item.message);
            WriteLine("------------------------------");
        }
    }
    

    

    
    }
}