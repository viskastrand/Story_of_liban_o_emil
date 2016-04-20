using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_of_liban_o_emil
{
    class Program
    {
        private static string input;

        static void Main(string[] args)

        {
            Boolean harNyckel = false;
            Boolean harKläder = false;
            Boolean självmord = false;

            string input;

            Console.WriteLine("---Välkommen till Emil och Libans äventyr!!!---");
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
                    självmord = true;
                }
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");

            }
            störrerum();
        }
        private static void störrerum()
        {
            Boolean harPlanka = false;

            Console.WriteLine("\nDu är nu i ett större rum med en trappa, det ligger en planka på golvet. Det fattas en planka från trappan så du kan inte gå upp.");
            Console.Write("\n>");
            while (true)
            {
                input = Console.ReadLine();

                if (input == "gå upp" || input == "trappa" || input == "gå up för trappan")
                {
                    if (harPlanka)
                    {
                        Console.WriteLine("Du går upp för trappan");
                        break;
                    }
                }
                else if (input == "ta planka" || input == "planka")
                {
                    Console.WriteLine("Du tog plankan och satte fast den på trappan.");
                    harPlanka = true;
                }

                else Console.WriteLine("Icke gilltigt eller felstavat commando!");
            }
                vinden();
            } 

        private static void vinden()
        {
            Console.WriteLine("\nDu har nu kommit till vinden.");
            Console.Write("\n>");
            while (true);

            }
        }
    }


