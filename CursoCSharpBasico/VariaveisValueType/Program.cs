using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 300;
            int segundoNumero = primeiroNumero;

            primeiroNumero = 500;

            Console.WriteLine($"Primeiro número = {primeiroNumero} e Segundo número = {segundoNumero}.");
            Console.ReadKey(true);
        }
    }
}
