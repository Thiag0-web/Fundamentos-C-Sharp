namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1072
    {
        public static void Executar()
        {
            int somaDentro = 0;
            int somaFora = 0;

            int ciclos = int.Parse(Console.ReadLine());

            for (int i = 0; i < ciclos; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 10 && n <= 20)
                {
                    somaDentro++;
                }
                else
                {
                    somaFora++;
                }
            }
            Console.WriteLine($"Numeros dentro:{somaDentro}");
            Console.WriteLine($"Numeros Fora:{somaFora}");
        }
    }
}