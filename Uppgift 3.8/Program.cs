using System;

namespace Uppgift_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord.");
            string ord1 = Console.ReadLine();
            Console.WriteLine("Skriv in ett ord till.");
            string ord2 = Console.ReadLine();
            Console.WriteLine("Skriv in ett sista ord också.");
            string ord3 = Console.ReadLine();

            if(ord1.CompareTo(ord2) < 0 && ord1.CompareTo(ord3) < 0)
                Console.WriteLine("Ord 1 kommer först i storleksordning.");
            if(ord2.CompareTo(ord1) < 0 && ord2.CompareTo(ord3) < 0)
                Console.WriteLine("Ord 2 kommer fört i storleksordning");
            if (ord3.CompareTo(ord1) < 0 && ord3.CompareTo(ord2) < 0)
                Console.WriteLine("Ord 3 kommer först i storleksordning");

            Console.ReadKey();
        }
    }
}