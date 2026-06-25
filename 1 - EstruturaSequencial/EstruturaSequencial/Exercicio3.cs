using System;
using System.Globalization;

namespace Exercicios
{
    public class Exercicio3
    {
        public static void Executar()
        {

            int A, B, C, D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);
        }
    }
}