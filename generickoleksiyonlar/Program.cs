using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> Class
            //system.collections.generic
            // T => OBJECT TÜRÜNDEdir.

            List<int> sayi =new List<int>();

            sayi.Add(23);
            sayi.Add(33);
            sayi.Add(3);
            sayi.Add(2);
            sayi.Add(24);

            List<string> cumle = new List<string>();

            cumle.Add("ferhat");
            cumle.Add("ersoy");
            cumle.Add("antalya");
            cumle.Add("burdur");

            //Eleman sayısı Count

            System.Console.WriteLine(sayi.Count);

            //foreach ile listforeach
            foreach (var item in sayi)
            {
                System.Console.WriteLine(item);
            }
            sayi.ForEach(sayi => System.Console.WriteLine(sayi));

            //Listeden eleman çıkarma
            sayi.Remove(3);
            cumle.Remove("ferhat");

            //index ile çıkarma
            sayi.RemoveAt(0);


            //Liste içerisinde Arama

            if (sayi.Contains(10))
                System.Console.WriteLine("10 vardır");
            
            //Eleman ile index e erişme

            cumle.BinarySearch("ersoy");

            //diziyi listeye çevirme

            string[] ifade = {"kedi", "köpek", "kuş"};

            List<string> hayvanlar = new List<string>(ifade);

            //Liste Temizleme
            hayvanlar.Clear();

            //Listeye Nesne tutmak

            List<kullanicilar> kullanici = new List<kullanicilar>();
            
            kullanicilar kullanici2 = new kullanicilar();
            kullanici2.isim ="ferhat";
             kullanici2.soyisim ="ersoy";
              kullanici2.yas =12;

             kullanicilar kullanici3 = new kullanicilar();
            kullanici3.isim ="ferhat";
             kullanici3.soyisim ="ersoy";
              kullanici3.yas =12;

              kullanici.Add(kullanici2);
              kullanici.Add(kullanici3);

              List<kullanicilar> yeniliste = new List<kullanicilar>();
              yeniliste.Add(new kullanicilar(){
                  isim = "betül",
                  soyisim = "ersoy",
                  yas = 45
              });


            foreach (var item in yeniliste)
            {
                System.Console.WriteLine("ad"+item.isim);
                System.Console.WriteLine("ad"+item.soyisim);
                System.Console.WriteLine("ad"+item.yas);

            }



        }
    }
    public class kullanicilar
    {
         private string isim;
         private string soyisim;
         private int yas;

         public string isim{get => isim; set => isim = value;}
          public string soyisim{get => soyisim; set => soyisim = value;}
           public int yas{get => yas; set => yas = value;}
    }
}