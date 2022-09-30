using System;
namespace Uppgift3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string Å = Console.ReadLine();
            int Ålder = Convert.ToInt32(Å);
            if (Ålder >= 16 && Ålder <= 19)
            {
                Console.WriteLine("Du får delta");
            }
            else if (Ålder < 16) 
            {
                Console.WriteLine("Du är för ung för att delta");
            }
            else if (Ålder > 19) 
            {
                Console.WriteLine("Du är för gammal för att delta");
            }

        }
    }
}
