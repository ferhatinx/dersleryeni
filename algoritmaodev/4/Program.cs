using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Kelime nedir: ");
            string a = Console.ReadLine();

            int harfsayisi =0;

            string[] kelime = a.Split(" ");
            System.Console.WriteLine("cümlede {0} kelime vardır",kelime.Length);
            for (int i = 0; i < kelime.Length; i++)
            {
                
                char[] harf = kelime[i].ToCharArray();
                harfsayisi+=harf.Length;
               
            }
             System.Console.WriteLine(harfsayisi);
        }
    }
}