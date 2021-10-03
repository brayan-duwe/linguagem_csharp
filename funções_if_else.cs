using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10;

            Console.WriteLine("Bom dia");

            if (y > 5)
            {
                Console.WriteLine("Boa tarde");
            }


            Console.WriteLine("Boa noite");

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
            Console.WriteLine("----------------------------------------");


            // essa é a forma não tão boa, pq se for < 12 por ex, ele vai testar os outros do msm jeito

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            if (hora >=12 && hora < 18) {
                Console.WriteLine("Boa Tarde!");
            }

            if (hora >= 18)
            {
                Console.WriteLine("Boa noite!");
            }

            // agr a melhor forma

            Console.WriteLine("Qual a hora atual?");
            int horaagr = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!"); 
            }

             // parte 2   

            int p = int.Parse(Console.ReadLine());
            if (p % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else  {
                Console.WriteLine("ímpar");
            }

        }


    }
}
