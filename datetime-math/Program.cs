using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Minute);

            System.Console.WriteLine(DateTime.Now.DayOfYear);
            System.Console.WriteLine(DateTime.Now.DayOfWeek);

            System.Console.WriteLine(DateTime.Now.ToLongDateString());
            System.Console.WriteLine(DateTime.Now.ToShortTimeString());

            System.Console.WriteLine(DateTime.Now.AddHours(1));
            System.Console.WriteLine(DateTime.Now.AddMonths(1));


            System.Console.WriteLine(DateTime.Now.ToString("dd"));
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));

            System.Console.WriteLine(DateTime.Now.ToString("yy"));
            System.Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //Math Sınıf

            System.Console.WriteLine(Math.Abs(-5));
            System.Console.WriteLine(Math.Pow(3,4));
            System.Console.WriteLine(Math.Round(12.5));

            System.Console.WriteLine(Math.Max(12,6));
            System.Console.WriteLine(Math.Min(12,6));

            System.Console.WriteLine(Math.Pow(2,5));
            System.Console.WriteLine(Math.Sqrt(9));





        }
    }
}