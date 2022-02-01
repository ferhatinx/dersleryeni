using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string metin = "Merhaba Dünya, bu örnek bir program";
            string sesli = "aeıioöuü";
 
            int sayac =0;
            for (int i = 0; i < metin.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if(sesli.Contains(metin[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine(metin);
           
 
        }
    }
}