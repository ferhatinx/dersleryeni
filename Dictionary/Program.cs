using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sozluk = new Dictionary<int, string>();

            sozluk.Add(1,"ferhat");
            sozluk.Add(2,"ferhat");
            sozluk.Add(3,"ferhat");

            System.Console.WriteLine(sozluk[1]);

            System.Console.WriteLine(sozluk.Count());

            sozluk.Remove(1);
            foreach (var item in sozluk)
            {
                System.Console.WriteLine(item);
            }

            foreach (var item in sozluk)
            {
                System.Console.WriteLine(sozluk.Keys);
            }



        }
    }
}