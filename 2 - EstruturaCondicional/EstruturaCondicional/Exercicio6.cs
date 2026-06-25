using System;
using System.Globalization;

namespace EstruturaCondicional
{
    public class Exercicio6
    {
        public static void Executar()
        {
            Console.WriteLine("Intervalos ([0,25], [25,50], [50,75], [75,100]):");

            double Numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Numero >= 0 && Numero <= 25)
            {
                Console.WriteLine("Intervalo (0,25)");
            }
            else if (Numero > 25 && Numero <= 50)
            {
                Console.WriteLine("Intervalo (25,50)");
            }

            else if (Numero > 50 && Numero <= 75)
            {
                Console.WriteLine("Intervalo (50,75)");
            }
            else if (Numero > 75 && Numero <= 100)
            {
                Console.WriteLine("Intervalo (75,100)");
            }
            else 
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
