using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = {"mor","mavi","yeşil",""};
            renkler[3]="sarı";

            foreach (var i in renkler)
            {
                System.Console.WriteLine(i);
            }

            Console.Write("dizi uzunluğu gir: ");
             int a =Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[a];
            int toplam=0;
            for (int i = 0; i < a; i++)
            {
                Console.Write(i+". elemanı gir");
                int b=Convert.ToInt32(Console.ReadLine());
                toplam+=b;
            }
            System.Console.WriteLine(toplam);


        }
    }
}