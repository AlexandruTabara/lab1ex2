using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura
            int a;
            int b;
            int c;

            Console.WriteLine("Acest program va calcula media artimetica a trei numere");

            Console.WriteLine("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Media artimetica este: " + (a + b + c) / 3);

        }
    }
}
