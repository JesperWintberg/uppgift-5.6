using System;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in dinna tal (tal1 * tal2)");
            string tal = Console.ReadLine();


            string[] split = tal.Split(" * ");
            int[] tal2 = Array.ConvertAll(split, int.Parse);

            int spara = 1;

            for(int i = 0; i < tal2.Length; i++)
            {

                spara = tal2[i] * spara;

            }

            Console.WriteLine(spara);
        }
    }
}
