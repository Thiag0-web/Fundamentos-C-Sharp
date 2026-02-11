using System;

namespace Calcula
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=========Bem-vindo à Calculadora Simples!=========");

            Console.WriteLine("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Soma: {num1 + num2}");
            Console.WriteLine($"Subtração: {num1 - num2}");
            Console.WriteLine($"Multiplicação: {num1 * num2}");

            if (num2 != 0)
            {
                Console.WriteLine($"Divisão: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Divisão: Erro (Divisão por zero)");
            }

            Console.WriteLine("\nCálculos concluídos! Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}