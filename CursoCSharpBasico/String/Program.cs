using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'C', 'r', 'i', 'a', 'n', 'd', 'o', ' ', 's', 't', 'r', 'i', 'n', 'g', 's', ' ', 'a', 'p', 'a', 'r', 't', 'i', 'r', ' ', 'd', 'e', ' ', 'u', 'm', ' ', 'a', 'r', 'r', 'a', 'y', ' ', 'd', 'e', ' ', 'c', 'h', 'a', 'r', 's', '.' };
            string string1 = new string(chars);
            Console.WriteLine(string1);

            string string2 = new string(chars, 8, 7);
            Console.WriteLine(string2);

            sbyte[] bytes = { 0x2, 0x3, 0x4 };

            string string3 = "Uma ";
            string string4 = "fraze qualquer";
            string string5 = "!";
            string string6 = string3 + string4;
            string6 += string5;
            Console.WriteLine(string6);

            string string7 = string6.Substring(4);
            Console.WriteLine(string7);

            StringBuilder sb = new StringBuilder();
            sb.Append("12345");
            sb.Append("67890");
            string str = sb.ToString();
            Console.WriteLine(str);

            string str1 = "ASDF";
            string str2 = "12345";
            string str3 = "ASDF";
            bool resultado = string.Compare(str1, str2, true) == 0;
            bool resultado2 = string.Compare(str1, str3, true) == 0;
            Console.WriteLine($"str1 é igual a str2 {resultado}");
            Console.WriteLine($"str1 é igual a str3 {resultado2}");

            string str4 = null;
            if (string.IsNullOrEmpty(str4))
            {
                Console.WriteLine("\nA String é nula ou vazia.");
            }

            Console.ReadKey(true);
        }
    }
}
