using System;
using System.Globalization;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {


            int idade = 32;
            double saldo = 10.35271;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);
    


            char genero = 'F';
            int idade = 32;
            double saldo = 10.42556;
            string nome = "Maria";

            Console.WriteLine("Bom dia");
            Console.Write("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
