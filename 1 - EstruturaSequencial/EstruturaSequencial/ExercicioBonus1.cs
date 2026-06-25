using System;
using System.Globalization;

namespace Exercicios
{
    public class ExercicioBonus1
    {
        public static void Executar()
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;
            
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
