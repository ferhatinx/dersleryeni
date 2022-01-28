using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
         ArrayList list = new ArrayList();
         list.Add("ayşe");
         list.Add(4);
         list.Add('A');
         list.Add(true);

        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
        string[] renkler = {"kırmızı", "yeşil"};
        List<int> sayilar = new List<int>(){1,2,3,45,6};
        list.AddRange(renkler);







        }
    }
}