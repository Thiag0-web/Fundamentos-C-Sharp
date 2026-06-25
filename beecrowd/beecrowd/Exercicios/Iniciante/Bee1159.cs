namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1159
    {
        public static void Executar()
        {

            while (true)
            {
                int x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    break;
                }
                if (x % 2 != 0)
                {
                    x++;
                }

                int soma = 0;

                for (int i = 0; i < 5; i++)
                {
                    soma = soma + x;
                    x = x + 2;
                }

                Console.WriteLine(soma);
            }

        }
    }
}
