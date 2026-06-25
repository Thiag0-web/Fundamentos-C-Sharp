namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1071
    {
        public static void Executar()
        {
            int valor1, valor2, soma, max, min;

            min = 0;
            max = 0;
            soma = 0;
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 < valor2)
            {
                min = valor1;
                max = valor2;
            }
            else
            {
                min = valor2;
                max = valor1;
            }

            for (int i = min + 1; i < max; i++)
            {
                soma = i;
                if (i % 2 == 0)
                {
                    soma += 1;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
