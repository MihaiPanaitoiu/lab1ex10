using System;
using System.Linq;

namespace lab1ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 10
                    Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.
                     Numarul are exact 2 cifre
             */

            Console.WriteLine("num = ");
            string num = Console.ReadLine();

            int result = num.Sum(p => int.Parse(p.ToString()));

            Console.WriteLine($"Suma cifrelor {num} este {result}");
        }
    }
}
