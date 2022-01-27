using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ifade = "dersimize csharp";
            string cumle = "dersimize hoşgeldiniz";
            //concet
            System.Console.WriteLine(string.Concat(cumle,"merhabalarla"));

            //compare, comparaTO
            System.Console.WriteLine(cumle.CompareTo(ifade));
            System.Console.WriteLine(string.Compare(cumle, ifade, true));

            //contains
            System.Console.WriteLine(cumle.Contains(ifade));

            //indexof

            System.Console.WriteLine(cumle.IndexOf("cs"));

            //insert
            System.Console.WriteLine(cumle.Insert(0,"merhabalar"));

            //padleft, padright
            System.Console.WriteLine(cumle.PadLeft(20));

            //remove
            System.Console.WriteLine(cumle.Remove(1,2));

            //replace
            System.Console.WriteLine(cumle.Replace("cs","ferhat"));

            //Split
            System.Console.WriteLine(cumle.Split(" ")[1]);

            //substring
            System.Console.WriteLine(cumle.Substring(4));

        }
    }
}