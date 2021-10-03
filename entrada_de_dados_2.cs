using System;
using System.Globalization;


namespace RE22Entr_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nomecompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos há na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Último nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string d1= vet[0];
            int d2 = int.Parse(vet[1]);
            double d3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            
            Console.WriteLine(nomecompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3.ToString(CultureInfo.InvariantCulture));

        }
    }
}
