using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calisanlar calisan1 = new calisanlar("ferhat",23);
            
            calisan1.calisanbilgileri();


        }
    }
    class calisanlar
    {
        public string ad;
        public int no;

        public calisanlar(string Ad, int No)
        {
            this.ad = Ad;
            this.no = No;
        }
        public calisanlar(){

        }
        public void calisanbilgileri(){

            System.Console.WriteLine("calisan adı: {0}",ad);
            System.Console.WriteLine("calisan no {0}",no);
        }

    }
}