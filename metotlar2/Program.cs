using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    
    
    class metotlar
    {

        public int topla(int x, int y , out int toplam)
        {
               toplam = x+y; 
        }
        public string yazdir(string s)
        {
             System.Console.WriteLine(s);   
        }
        public string yazdir(int s)
        {
             System.Console.WriteLine(s);   
        }
    }
    
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
           //out parametreler
            string sayi = "999";

           bool sonuc = int.TryParse(sayi, out int outsayi);
           if (true)
           {
               System.Console.WriteLine("başarılı");
               System.Console.WriteLine(outsayi);
           }
            else
            {
                System.Console.WriteLine("başarısız");
            }
            metotlar instance = new metotlar();
            instance.topla(2,30, out int toplam2);
            System.Console.WriteLine(toplam2);

            //overloading
        
            int ifade = 99;
            instance.yazdir(ifade.ToString());

            //metot imzası
        
        
        }

    }
}