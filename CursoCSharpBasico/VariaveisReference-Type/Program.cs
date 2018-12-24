using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pastel = new Produto();
            pastel.AlteraQuantidade(300);

            Produto caldoDeCana = new Produto();
            caldoDeCana = pastel;

            pastel.AlteraQuantidade(500);

            Console.WriteLine($"Pastel = {pastel.Quantidade} e Caldo de Cana = {caldoDeCana.Quantidade}");
            Console.ReadKey(true);
        }
    }
}
