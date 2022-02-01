using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
       {
            void diziyazdirma(ArrayList a)
            {
            
                foreach (var item in a)
                {
                    
                    System.Console.WriteLine(item);
                }

            } 
            ArrayList dizi = new ArrayList();
            ArrayList dizi2 = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("bir sayı giriniz: ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a%2==0 || a%3==0)
                {
                   dizi.Add(a); 
                }
                else if( a == 2)
                {
                   dizi2.Add(a);
                }
                else
                {
                   dizi2.Add(a);
                }

            }
            System.Console.WriteLine("******AsalOlmayan*******");
            diziyazdirma(dizi);
            System.Console.WriteLine("******asal*******");
            diziyazdirma(dizi2);


        }
    }
    
}