using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    public class Exercicio1
    {
        public static void Executar()
        {
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("Soma = " + soma);
        } 
    }
}
