using System;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome =  Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");

            string[] vet = Console.ReadLine().Split(' ');
            string nomeVet = vet[0];
            int idadeVet = int.Parse(vet[1]);
            double alturaVet = double.Parse(vet[2]);


                
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(nomeVet);
            Console.WriteLine(idadeVet);
            Console.WriteLine(alturaVet);

        }
    }
}