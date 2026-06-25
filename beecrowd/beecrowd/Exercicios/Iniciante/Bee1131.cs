using System;

namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1131
    {
        public static void Executar()
        {
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int totalGrenais = 0;
            int opcao = 1;

            while (opcao == 1)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(entrada[0]);
                int golsGremio = int.Parse(entrada[1]);

                totalGrenais++;


                if (golsInter > golsGremio)
                {
                    vitoriasInter++;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriasGremio++;
                }
                else
                {
                    empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{totalGrenais} grenais");
            Console.WriteLine($"Inter:{vitoriasInter}");
            Console.WriteLine($"Gremio:{vitoriasGremio}");
            Console.WriteLine($"Empates:{empates}");

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}