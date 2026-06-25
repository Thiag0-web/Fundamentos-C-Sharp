using System;

namespace CadastroAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            double[] medias = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\n===== ALUNO {i + 1} =====");

                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Nota 1: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Nota 2: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Nota 3: ");
                double n3 = double.Parse(Console.ReadLine());

                medias[i] = (n1 + n2 + n3) / 3.0;
            }

            Console.WriteLine("\n===== RESULTADO =====");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nAluno: {nomes[i]}");
                Console.WriteLine($"Média: {medias[i]:F2}");

                if (medias[i] >= 7.0)
                {
                    Console.WriteLine("Status: APROVADO");
                }
                else
                {
                    Console.WriteLine("Status: REPROVADO");
                }
            }

            Console.WriteLine("\nPressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}