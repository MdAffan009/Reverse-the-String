using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to this Program!");
            Console.WriteLine("This Program could reverse any word that you will give!");
            Console.WriteLine("So, What is your word?");
            string? Word = Console.ReadLine();

            string Null = "\0";

            Word += Null;

            int count = Word.Length;

            for (int i = 0; i < count; i++)
            {
                int eqn = count - 1 - i;

                Console.Write(Word[eqn]);
            }


            Console.ReadKey();
        }
    }
}