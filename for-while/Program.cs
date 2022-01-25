using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("bir sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
               if (i % 2 != 0)
               {
                  System.Console.WriteLine(i);
               }
               else
               {
                   continue;*/
               
               int n = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i<=20;i++){
                     Console.WriteLine("n"+"x"+"i"+"="+n*i);
            
                }
               }
            }
        }
    }
}