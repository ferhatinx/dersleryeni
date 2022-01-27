using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kaç kelime: ");
            int a =Convert.ToInt32(Console.ReadLine());
            string[] dizi = new string[a];

            for (int i = 0; i < a; i++)
            {
                Console.Write("kelime: ");
                string b =Console.ReadLine();
                dizi[i]=b;
            }
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}