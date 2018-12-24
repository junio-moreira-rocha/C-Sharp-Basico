using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("\nQual é o seu nome?");

            var nome = Console.ReadLine();
            var data = DateTime.Now;

            Console.WriteLine($"\nOlá {nome}, em {data:d} as {data:t}!");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");

            Console.ReadKey(true);
        }
    }
}
