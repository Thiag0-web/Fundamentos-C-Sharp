using System;

namespace EstruturaCondicional
{
    public class Exercicio4
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a hora inicial e a hora final (0 a 24):");
            string[] entrada = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(entrada[0]);
            int horaFinal = int.Parse(entrada[1]);

            int duracao;

            if (horaFinal > horaInicial)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = (24 - horaInicial) + horaFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}