using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi ={12,5,6,1,74};
            Array.Sort(dizi);

            System.Console.WriteLine(dizi) ;


            Array.Clear(dizi,3,1);

            System.Console.WriteLine(dizi);
            Array.Reverse(dizi);

            System.Console.WriteLine(dizi);
            Array.IndexOf(dizi,5);

            System.Console.WriteLine(dizi);
        }
    }
}