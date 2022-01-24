using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
                    Console.WriteLine("sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("girdiğiniz sayi"+sayi);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("hata: "+ ex.Message.ToString());
            }
            finally{
                    System.Console.WriteLine("işlem tamamlandı");
            }
            

            try
            {
                //int a =int.Parse(null);
                  //  int a = int.Parse("test");
                  int a = int.Parse("-2000000000");
            }
            catch (ArgumentNullException ex)

            {
                
                System.Console.WriteLine("veri tipi uygun değil");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                System.Console.WriteLine("cok büyük değer girdin");
                System.Console.WriteLine(ex);
            }
            finally{
                System.Console.WriteLine("işlem başarılıdır");
            } 
        
        }
    }
}