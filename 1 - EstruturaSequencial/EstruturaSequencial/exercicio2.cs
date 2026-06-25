using System;
using System.Globalization;

namespace Exercicios
{
    public class Exercicio2
    {
        public static void Executar()
        {

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}