using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicios
{
    public class Exercicio4
    {
        public static void Executar()
        {
            int Numero;
            double Hora, ValorHora, Salario;

            Numero = int.Parse(Console.ReadLine());
            Hora = double.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Salario = Hora * ValorHora;

            Console.WriteLine("NUMBER = " + Numero);
            Console.WriteLine("SALARIO = " + Salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}