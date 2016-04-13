using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_of_liban_o_emil
{
    class Program
    {
        static void Main(string[] args)

        {
            Boolean harNyckel = false;
            Boolean harKläder = false;
            
            string input;

            Console.WriteLine("---Välkommen till Karl-Axels Command Line Adventure---");
            Console.WriteLine("\nDu står i ett tomt rum. Detta enda som finns är en dörr framför dig. Det ligger en nyckel på golvet");
            while (true) //oändlig loop
            {
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "dörr" || input == "öppna dörr" || input == "gå till dörr")
                {
                    if (harNyckel)
                        if (harKläder)
                        {
                            Console.WriteLine("Du öppnar dörren och går igenom");
                            break;
                        }
                        else
                            Console.WriteLine("Den är låst, och du måste ha kläder på dig när du går ut");
                }

                else if (input == "nyckel" || input == "ta nyckel")
                {
                    Console.WriteLine("Du tog nyckeln");
                    harNyckel = true;
                }

                else if (input == "kläder" || input == "ta kläder")
                {
                    Console.WriteLine("Du tog kläderna!");
                    harKläder = true;   
                }
                else if (input == "självmord")
                {
                    Console.WriteLine("Du sprang rakt in i väggen och dog");
                    
                }
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");
                    
                }
                Console.WriteLine("\nGrattis du gick ut genom dörren!");
            Console.ReadLine();


        }
    }
}

