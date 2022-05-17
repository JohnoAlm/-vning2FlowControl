using System;

namespace Övning2FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? choice;

            do
            {
                // Alla dessa metoder kallas också från Util klassen för att göra koden mindre stökig
               
                Util.DisplayMenu();

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Util.TicketChecker();
                        break;

                    case "2":
                        Util.RepeatTenTimes();
                        break;

                    case "3":
                        Util.TheThirdWord();
                        break;

                    // Om användaren skriver fel tecken
                    default:
                        Console.WriteLine("Fel inmatning, försök igen");
                        break;
                }
                
            // Så länge användaren inte trycker på 0 så stannar vi kvar i do-while loopen för evigt   
            } while (choice != "0");

            Console.WriteLine("Stänger applikation...");
        }
    }
}
