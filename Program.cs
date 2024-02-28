using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Uppg_6_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ytterligare ett tal:");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Största talet är lika med {Störst(tal1, tal2)}");
        }


        static int Störst(int tal1, int tal2)
        {
            int störstatal = tal1;
            if (tal1 < tal2)
            {
                störstatal = tal2;
            }
            return störstatal;
        }
    }
}