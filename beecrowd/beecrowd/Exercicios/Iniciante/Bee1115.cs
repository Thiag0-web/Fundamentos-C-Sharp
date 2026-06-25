namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1115
    {
        public static void Executar()
        {
            while (true)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (x == 0 || y == 0)
                {
                    break;
                }

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }

                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }

                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}
/* 
Escreva um programa para ler as coordenadas (X, Y) de um número indeterminado de pontos no sistema cartesiano. 
Para cada ponto, escreva o quadrante ao qual ele pertence. 
O programa deve terminar quando pelo menos uma das duas coordenadas for NULL (nesse caso, sem exibir nenhuma mensagem). 
*/