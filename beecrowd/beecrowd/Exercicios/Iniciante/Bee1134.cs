namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1134
    {
        public static void Executar()
        {
            Console.WriteLine("1. Álcool 2. Gasolina 3. Diesel 4. Fim");
            int adicionar, alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;
            adicionar = 0;

            while (adicionar != 4)
            {
                adicionar = int.Parse(Console.ReadLine());

                if (adicionar == 1)
                {
                    alcool++;
                    Console.WriteLine($"Alcool: {alcool} Gasolina: {gasolina} Diesel: {diesel}");
                }
                else if (adicionar == 2)
                {
                    gasolina++;
                    Console.WriteLine($"Alcool: {alcool} Gasolina: {gasolina} Diesel: {diesel}");
                }
                else if (adicionar == 3)
                {
                    diesel++;
                    Console.WriteLine($"Alcool: {alcool} Gasolina: {gasolina} Diesel: {diesel}");
                }
                else if (adicionar == 4)
                {
                    break;
                }
                Console.WriteLine("MUITO OBRIGADO");
            }            
        }
    }
}
