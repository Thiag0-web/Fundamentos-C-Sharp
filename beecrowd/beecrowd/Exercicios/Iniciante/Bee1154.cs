using System;
using System.Globalization;

namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1154
    {
        public static void Executar()
        {
            double soma;
            int idade, contagem;

            idade = 0;
            soma = 0;
            contagem = 0;

            while (true)
            {
                idade = int.Parse(Console.ReadLine());
                if (idade < 0)
                {
                    break;
                }

                soma = soma + idade;
                contagem++;
            }
            if (contagem > 0)
            {
                double media = soma / contagem;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}


/*
Escreva um algoritmo para ler um número indeterminado de dados, cada um contendo a idade de um indivíduo. 
Os dados finais, que não serão usados ​​nos cálculos, contêm o valor de uma idade negativa. 
Calcule e imprima a idade média desse grupo de indivíduos.

Entrada
A entrada contém um número indeterminado de números inteiros. 
A entrada será interrompida quando um valor negativo for lido.

Saída
O resultado contém um valor correspondente à idade média dos indivíduos.

A média deve ser impressa com duas casas decimais. 
*/