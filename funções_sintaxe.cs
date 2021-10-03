using System;

namespace Funções__sintaxe_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // forma mais prática - delegando

            double resultado = Maior(a, b, c);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int x, int y, int z)
        {
            int m;
            if (x > y && x > z)
            {
                m = x;
            }
            else if (y > z)
            {
                m = y;
            }
            else
            {
                m = z;
            }
            return m;
        }
    }
}
