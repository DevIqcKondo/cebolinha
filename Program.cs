using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("Você poderia me ajudar com um exercício?");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Se sim, tecle ENTER");
            Console.WriteLine("-------------------");
            Console.ReadKey();
            Console.Write("Vamos começar com seu nome? ");
            Console.Write("Digite seu nome: ");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            string nome=Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("Agora "+nome+" digite uma frase: ");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            string frase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(frase = frase.Replace("r", "l"));
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("Eita "+nome+", é você ou o cebolinha?");
            Console.ResetColor();

            
        }
    }

}
