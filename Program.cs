using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            

            string nome;
            Console.WriteLine("Olá qual é seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}!");
        }
    }
}
