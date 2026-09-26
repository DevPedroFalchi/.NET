using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            Console.Write("Clliente Especial");
            var resposta = Console.ReadLine();

            if (resposta == "S")
            {
                Console.WriteLine("Cliente Especial");
            }
            else
            {
                Console.WriteLine("Cliente Normal");
            }


            Console.ReadKey();
        }
    }
}
