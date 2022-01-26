using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           metotlar ustalma = new();
           System.Console.WriteLine(ustalma.ust(5,3));

            //extension metotlar
        
           string ifade = "ferhat ersoy";
           Console.WriteLine(ifade.CheckSpaces());
            System.Console.WriteLine(ifade.RemoveWhiteSpaces());
            System.Console.WriteLine(ifade.Uppercase());            

            int[] dizi = {9,3,4,6,5,1};

            System.Console.WriteLine(dizi.SortArray());
            dizi.SortArray();
       }
    }
    public class metotlar
    {
        public int ust(int sayi, int ustu)
        {
               if (ustu <2 )
               {
                 return sayi;
               }
               else
               {
                 return ust(sayi, ustu-1)*sayi;
               }   
           
               
        }
        
    }
    public static class Extension{
        public static bool CheckSpaces(this string param)
        {
               return param.Contains(" "); 
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi =param.Split(" ");
            return string.Join("",dizi);
        }
        public static string Uppercase(this string param)
        {
               return param.ToUpper(); 
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void ekranayazdir(this string param)
        {
            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
        }

    }
}