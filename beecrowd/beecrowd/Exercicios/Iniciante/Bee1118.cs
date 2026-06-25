namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1118
    {
        public static void Executar()
        {
            double nota1, nota2, media;
            int novoCalculo = 1;

            while (novoCalculo == 1)
            {

                nota1 = double.Parse(Console.ReadLine());
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }

                nota2 = double.Parse(Console.ReadLine());
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }

                media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media:F2}");

                novoCalculo = 0;
                while (novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
