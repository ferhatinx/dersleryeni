using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           calisan calisan1 = new calisan();
           calisan1.ad="Ayşe";
           calisan1.soyad="Ayşe";
           calisan1.No=1;
           calisan1.Departman="discord";
           
           calisan1.CalisanBilgileri();

           calisan calisan2 = new calisan();
           calisan1.ad="fatma";
           calisan1.soyad="fatma";
           calisan1.No=1;
           calisan1.Departman="twitch";

             calisan2.CalisanBilgileri();
        }
    }
    class calisan
    {
        public string ad;
        public string soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri(){
            System.Console.WriteLine("çalışan adı: {0} ", ad);
            System.Console.WriteLine("çalışan adı: {0} ", soyad);
            System.Console.WriteLine("çalışan adı: {0} ", No);
            System.Console.WriteLine("çalışan adı: {0} ", Departman);

        }
    }
}