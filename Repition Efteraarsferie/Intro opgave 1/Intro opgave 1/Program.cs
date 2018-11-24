using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1.1");

            Console.WriteLine("Hello world");

            Console.WriteLine("Opgave 1.2");

            Console.WriteLine("Hello world, Hej verden, hallo welt, hola mundo, bonjour monde");

            Console.WriteLine("Opgave 1.3");

            string hello = "Hello world, Hej verden, hallo welt, hola mundo, bonjour monde";
            Console.WriteLine("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast efternavn: ");
            string efterNavn = Console.ReadLine();
            Console.WriteLine("Indtast tlf nr: ");
            string tlfNr = Console.ReadLine();

            Console.WriteLine($"{hello} {navn} {efterNavn} (mobil: {tlfNr})");

            Console.WriteLine("Opgave 1.5");

            Console.WriteLine("Indtast 2 tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("+");
            int tal2 = int.Parse(Console.ReadLine());
            int resultat1 = tal1 + tal2;
            int resultat2 = tal1 - tal2;
            int resultat3 = tal1 * tal2;
            int resultat4 = tal1 / tal2;
            Console.WriteLine($"{tal1} + {tal2} = {resultat1}");
            Console.WriteLine($"{tal1} - {tal2} = {resultat2}");
            Console.WriteLine($"{tal1} * {tal2} = {resultat3}");
            Console.WriteLine($"{tal1} / {tal2} = {resultat4}");

            Console.WriteLine("Opgave 1.6");

            int thisYear = DateTime.Now.Year;
            Console.WriteLine("Indtast din alder: ");
            int age1 = int.Parse(Console.ReadLine());
            int pensionage = 68;
            Console.WriteLine($"Du er {age1} år gammel, pensionsalderen er {pensionage}, " +
            $"derfor er der {pensionage - age1} år til " +
            $"du kan pensionere, i år {(pensionage - age1) + thisYear}.");

            Console.WriteLine("Opgave 1.7");
            Console.WriteLine("Du holder fest, du skal finde ud af hvor mange pizza stykker er til overs");
            Console.WriteLine("Indtast antal gæster: ");
            int guests = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast antal pizzaer: ");
            int pizzas = int.Parse(Console.ReadLine());
            int slices = 8;
            Console.WriteLine($"Leftover pizza slices: {(pizzas*slices) % guests}.");

            Console.WriteLine("Opgave 1.8");

            double varer = 4995 + 299 + 19 + 7 + 110;
            Console.WriteLine("Super solutions IVS");
            Console.WriteLine("Per jukumsen");
            Console.WriteLine("Per's CVR: 16486135");
            Console.WriteLine($"Solgte varer total: {varer}.");
            Console.WriteLine($"salgspris med moms {(varer*0.25)+varer},- og pris uden moms {varer}");

            Console.WriteLine("Bonus opgave");
            double session = 15000;
            double antalSessions = double.Parse(Console.ReadLine());
            Console.WriteLine($"Hver session er {session}kr, angiv antallet af sessioner {antalSessions}, " +
                $"total indtjening {((session*antalSessions)+varer)*0.25+ (session * antalSessions) + varer} efter moms.");

            Console.ReadLine();
        }
    }
}
