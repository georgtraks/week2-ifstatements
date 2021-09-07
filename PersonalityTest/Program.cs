using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsibkasutaja käest sisestada tema lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oledtöökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab miagi muud, kosool kuvab "oled ükssarvik";

            Console.WriteLine("mis su lemmikvärv?");
            string UserColor = Console.ReadLine();

            if(UserColor == "punane")
            {
                Console.WriteLine("sa oled romantiline.");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("sa oled töökas.");
            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("sa oled looduse sõber");
            }
            else
            {
                Console.WriteLine("oled ükssarvik.");
            }
        }
    }
}
