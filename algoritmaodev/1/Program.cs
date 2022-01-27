using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("kaç sayı giriceniz: ");
           int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.Write("sayı giriniz");
                int b =Convert.ToInt32(Console.ReadLine());

                if (b % 2 == 0)
                {
                    System.Console.WriteLine(b);
                }
                else{
                    continue;
                }
            }
        }
    }
}