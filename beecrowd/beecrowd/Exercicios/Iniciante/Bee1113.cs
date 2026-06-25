namespace beecrowd.Exercicios.Iniciante
{
    public class Bee1113
    {
        public static void Executar()
        {
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x < y) {
                    Console.WriteLine("Crescente");
                }
                else {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}

/* 
 Leia um número indeterminado de pares de valores inteiros. 
Escreva uma mensagem para cada par indicando se os dois números estão em ordem crescente ou decrescente.

Entrada
O arquivo de entrada contém vários casos de teste. Cada caso de teste contém dois números inteiros, X e Y. 
A entrada será considerada concluída quando X = Y.

Saída
Para cada caso de teste, imprima “Crescente” se os valores X e Y estiverem em ordem crescente; 
caso contrário, imprima “Decrescente”.
 */