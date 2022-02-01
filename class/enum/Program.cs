using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sicaklik = 23;

            if (sicaklik < (int)havadurumu.normal)
            {
                System.Console.WriteLine("soğuk");
            }
            else if (sicaklik < (int)havadurumu.sicak)
            {
                System.Console.WriteLine("normal");
            }
            else
            {
                System.Console.WriteLine("sıcak");
            }
        }
    }
  enum Gunler 
    {
        Pazartesi, 
        Sali, 
        Carsamba, 
        Persembe, 
        Cuma, 
        Cumartesi, 
        Pazar
    }
    enum havadurumu
    {
        soguk = 5,
        normal = 20,
        sicak=40,
    }
}