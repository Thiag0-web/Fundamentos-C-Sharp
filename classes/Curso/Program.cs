using System;

namespace CompararIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Digite o nome da primeira pessoa: ");
            string nome1 = Console.ReadLine() ?? "";

            Console.Write("Digite o salário da primeira pessoa: ");
            double salario1 = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine();

            Console.Write("Digite o nome da segunda pessoa: ");
            string nome2 = Console.ReadLine() ?? "";

            Console.Write("Digite o salário segunda pessoa: ");
            double salario2 = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine();

            double media = (salario1 + salario2) / 2;
            Console.WriteLine($"A média de salário é: ${media}");
        }
    }
}
