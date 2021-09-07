using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaa vanust
            //kui kasutaja on vanem, kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja onnoorem, kui18, siis konsoolis "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("kui vana sa oled?");

            int age = Int32.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("oled piisavalt vana");
            }
            else if (age < 18)
            {
                Console.WriteLine("oled liiga noor");
            }
            else {
               Console.WriteLine("oledki 18.");
            }

                    

            Console.WriteLine("ilusat päeva!");
        }
    }
}
