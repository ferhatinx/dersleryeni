using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
       {
            
            ArrayList dizi = new ArrayList();
            ArrayList dizi2 = new ArrayList();
            ArrayList dizi3 = new ArrayList();
            for (int i = 0; i <= 6; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                int a = Convert.ToInt32(Console.ReadLine());

                dizi.Add(a);
            }
            
            dizi.Sort();
            
            int toplam1=0;
            int toplam2=0;
            toplam1+= dizi2.Add(dizi[0]);
            toplam1+=dizi2.Add(dizi[1]);
            toplam1+=dizi2.Add(dizi[2]);
              
            toplam2+= dizi3.Add(dizi.Count-1);
            toplam2+=dizi3.Add(dizi.Count-2);
            toplam2+=dizi3.Add(dizi.Count-3);

            toplam1 = toplam1 /3;
            toplam2 = toplam2 /3;

            System.Console.WriteLine(toplam1);
            System.Console.WriteLine(toplam2);
        }
    }
    
}