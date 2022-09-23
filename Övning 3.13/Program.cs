using System;
namespace Uppgift3._13
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur gammal är du?");
            string Å = Console.ReadLine();
            int Ålder = Convert.ToInt32(Å);
            if (Ålder >= 16 && Ålder <= 19)
            {
                Console.WriteLine("Du får delta");
            }
            else
            {
                Console.WriteLine("Du får inte delta");
            }

        }
    }
}
