using System;

namespace EstruturaCondicional
{
    public class Exercicio2
    {
        public static void Executar()
        {
            double Numero;

            Console.WriteLine("Digite um número para descobrir se é par ou ímpar:");
            Numero = double.Parse(Console.ReadLine());

            if (Numero % 2 == 0)
            {
                Console.WriteLine($"O número {Numero} é positivo");
            }
            else
            {
                Console.WriteLine($"O número {Numero} é negativo");
            }
        }
    }
}
