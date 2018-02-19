using System;

namespace _014Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];

            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            Console.WriteLine("\t***For***");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Elemento [{0}]: {1}", i, n[i]);
            }

            Console.WriteLine("\n\t***Foreach***");
            foreach (int i in n)
            {
                Console.WriteLine("Elemento [{0}]: {1}", (i - 100), i);
            }

            Console.ReadLine();
        }
    }
}