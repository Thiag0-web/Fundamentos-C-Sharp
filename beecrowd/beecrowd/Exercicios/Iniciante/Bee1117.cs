using System.Globalization;

namespace beecrowd.Exercicios.Iniciante

{
    public class Bee1117
    {
        public static void Executar()
        {
            double soma = 0.0;
            int contador = 0;

            while (contador < 2)
            {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota >= 0 && nota <= 10)
                {
                    soma = soma + nota;
                    contador++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

            }

            double media = soma / 2.0;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
