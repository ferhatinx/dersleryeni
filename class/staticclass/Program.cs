using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calisan calisan = new calisan("ferhat");
            System.Console.WriteLine("calisan sayisi:"+calisan.Calisansayiyisi);
        }
    }
    class calisan
    {
        private static int calisansayiyisi;
        
        private string isim;

        public static int Calisansayiyisi { get => calisansayiyisi; set => calisansayiyisi = value; }
    
        static calisan(){
            calisansayiyisi =0;
        }
        public calisan(string isim)
        {
            this.isim = isim;
            calisansayiyisi++;
        }
    
    }
}