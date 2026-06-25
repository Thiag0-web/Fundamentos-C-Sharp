using System;

namespace EstruturaCondicional
{
    public class Exercicio1
    {
        public static void Executar()
        {
            int Numero;

            Console.WriteLine("Digite um número para descobrir se é positivo ou negativo:");
            Numero = int.Parse(Console.ReadLine());

            if (Numero >= 0)
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
