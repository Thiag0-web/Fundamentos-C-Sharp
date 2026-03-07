using System;
namespace Jogo
{
    public class Personagem
    {
        public string Nome;
        public string Classe;

        public Personagem(string NomePersonagem, string ClassePersonagem)
        {
            this.Nome = NomePersonagem;
            this.Classe = ClassePersonagem;
        }
    }
    class Program
    {
        static void Main()
        {
            Personagem Thiago = new("Thiago", "Mago");
            Console.WriteLine($"Nome do Personagem: {Thiago.Nome}");
            Console.WriteLine($"Classe do Personagem: {Thiago.Classe}");
        }
    }
}

