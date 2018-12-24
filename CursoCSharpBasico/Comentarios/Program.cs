using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder comentario = new StringBuilder("Comentários são textos inseridos no código");
            comentario.Append(" e que são desprezados pelo compilador,");
            comentario.Append(" ou seja,");
            comentario.Append(" não são levados em consideração ao gerar a aplicação.");
            Console.WriteLine(comentario);
            Console.WriteLine();

            comentario.Clear();

            Console.WriteLine(@"// Os comentários por linha se iniciam por duas barras.");
            Console.WriteLine();

            comentario.AppendLine(@"/* Comentários por bloco.");
            comentario.AppendLine(@" * Esse tipo de Comentário pode conter várias linhas.");
            comentario.AppendLine(@" * Iniciar com ""barra-asterisco"" e terminar com ""asterisco-barra"".");
            comentario.AppendLine(@" */");
            Console.WriteLine(comentario);

            //Evite fazer comentários desnecessários no código, pois pode dificultar sua legibilidade e manutenção.

            Console.ReadKey();
        }
    }
}
