using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/*
 Exercício 1 - Relógio Digital
 Criar um relógio em C# que mostre a hora atual no formato
 HH:MM:SS, atualizando a cada segundo.
 Para finalizar o programa, o usuário deve pressionar
 a tecla X ou x.

 */



class Program
{
    static void Main()
    {
        bool continuar = true;

        Console.WriteLine("RELÓGIO DIGITAL");
        Console.WriteLine("Pressione X para sair.");
        Console.WriteLine();

        while (continuar)
        {
            // Pega a hora atual
            DateTime horaAtual = DateTime.Now;

            // Mostra a hora na mesma linha
            Console.Write("\r" + horaAtual.ToString("HH:mm:ss"));

            // Verifica se alguma tecla foi pressionada
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(true);

                // Verifica se foi X ou x
                if (tecla.Key == ConsoleKey.X)
                {
                    continuar = false;
                }
            }

            // Aguarda 1 segundo
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        Console.WriteLine("Programa finalizado.");
    }
}
