using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
           
      
           int sonuc = topla(5,4);
           System.Console.WriteLine(sonuc);

          metotlar ornek =new metotlar();
          ornek.ekranayazdır(sonuc.ToString()); 
        }
         static int topla(int x, int y){
           return x+y;
        }
    }

class metotlar
{

    public void ekranayazdır(string veri){
        System.Console.WriteLine(veri);
    }
}
}