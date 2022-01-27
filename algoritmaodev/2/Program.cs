using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kaç sayı girilecek: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("bölünmesi istenilen sayi: ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("sayı nedir: ");
               int z = Convert.ToInt32(Console.ReadLine());
               if (z % y == 0 || z == y)
               {
                   System.Console.WriteLine(z);
               }
               else{
                   continue;
               }

            }

        
        }
    }
}