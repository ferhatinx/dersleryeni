using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a= 13;  
            for (int i = 0; i < a; i++)
            {
               if (i % 2 != 0)
               {
             (     System.Console.WriteLine(i);
               }
               else
               {
                   continue;
                }
            }

            int sayi = 5;
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)

            {
                toplam+=sayac;
                sayac++;    
            }
            System.Console.WriteLine(toplam/sayi);
        
            System.Console.WriteLine("*******foreach*******");
            string[] arabalar = {"bmw","mercedes","ford"};
            foreach (var i in arabalar)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}