using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2FlowControl
{
    /* Denna klass använder jag enbart för att kalla på dessa metoder och därför använder jag static.
    Jag ska alltså inte instansera någonting utan använder denna klassen enbart för att göra programklassen
    mindre cluttered av kod. Det är så jag antar att static ska användas, alltså till hjälpar klasser som denna.*/
    internal static class Util
    {
        public static void DisplayMenu()
        {
            /* Kanske lite många console writelines och finns säkert bättre sätt att skriva ut en meny med mindre kod.
            Tycker dock att detta mer visualiserar hur det faktiskt kommer se ut i konsolen.*/

            Console.WriteLine("\n");
            Console.WriteLine("Välkommen till huvudmenyn!");
            Console.WriteLine("Vänligen välj vad du vill göra:");
            Console.WriteLine("____________________________________________");
            Console.WriteLine("1. Beställ biljetter");
            Console.WriteLine("2. Upprepa tio gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine("0. Stäng applikation");
        }

        public static void TicketChecker()
        {
            /*Till denna metod så har jag bytt ut antal personer mot biljetter. Alltså var och en av
            personerna representerar en biljett. Istället då för att skriva ut antalet personer i slutet
            skriver jag ut antalet biljetter alltså tex 5 biljetter = 5 personer.*/

            Console.WriteLine("Välj antal biljetter:");
            string? ticket = Console.ReadLine();
            int ticketAmount;
            int sum = 0;
            if (int.TryParse(ticket, out ticketAmount))
            {
                for (int i = 0; i < ticketAmount; i++)
                {
                    Console.WriteLine("\nAnge ålder:");
                    string? age = Console.ReadLine();
                    int ageValue;

                    if (int.TryParse(age, out ageValue))
                    {

                        if (5 < ageValue && ageValue < 20)
                        {
                            Console.WriteLine("Ungdomspris: 80kr"); 
                            sum = sum + 80;
                        }

                        else if (ageValue > 64 && ageValue < 100)
                        {
                            Console.WriteLine("Pensionärspris: 90kr");
                            sum = sum + 90;
                        }

                        else if (ageValue >= 100)
                        {
                            Console.WriteLine("Extremt gammal pensionärspris: Gratis!");
                            sum = sum + 0;
                        }

                        else if(0 <= ageValue && ageValue <= 5)
                        {
                            Console.WriteLine("Bebispris: Gratis!");
                            sum = sum + 0;
                        }

                        else
                        {
                            Console.WriteLine("Standardpris: 120kr");
                            sum = sum + 120;
                        }
                    }
                }
                 Console.WriteLine("\nSummering");
                 Console.WriteLine("_____________");
                 Console.WriteLine($"Antal biljetter: {ticketAmount}");
                 Console.WriteLine($"Summa att betala: {sum}kr");
            }
        }

     
        public static void RepeatTenTimes()
        {
            Console.WriteLine("Ange valfri godtycklig text:");

            string? text = Console.ReadLine();
            Console.WriteLine("\n");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}.{text}");
            }
        }

        public static void TheThirdWord()
        {
            Console.WriteLine("Ange en mening med minst tre ord");
            
            var input = Console.ReadLine();
            
            string[] ord = input.Split(' ');

            if(ord.Length < 3)
            {
                Console.WriteLine("Fel inmatning, du måste ange minst tre ord, försök igen");
            }
            else
            {
                Console.WriteLine($"\nDet tredje ordet är: {ord[2]}");
            }
        }
    }
}
