using System;

namespace Aula02
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo...");
            if (args.GetLength(0) > 0)
            {

                Console.Write(args.GetValue(0));
            }
        }
    }
}