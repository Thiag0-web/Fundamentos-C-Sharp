namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1114
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a senha:");
            while (true)
            {
                int x = int.Parse(Console.ReadLine());

                if (x == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha invalida!");
                }
            }
        }
    }
}

/* Escreva um programa que continue lendo uma senha até que ela seja válida. 
 * Para cada senha incorreta lida, 
 * escreva a mensagem "Senha inválida". 
 * Quando a senha for digitada corretamente, 
 * imprima a mensagem "Acesso Permitido" e finalize o programa. A senha correta é o número 2002. 
 * 
 * 
namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1114
    {
        public static void Executar()
        {
            Console.WriteLine("Tente acertar a senha:");
            while (true)
            {
                int tentativa = int.Parse(Console.ReadLine());
                if (tentativa == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");

                }
            }
        }
    }
}
*/