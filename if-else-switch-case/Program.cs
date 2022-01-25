using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int time = DateTime.Now.Month;
        
        if (time < 4)

        {
            System.Console.WriteLine("ilk yarı");    
        }
        else if(time < 8)
        {
            System.Console.WriteLine("ikinci yarı");
        }
        else
        {
            System.Console.WriteLine("üçüncü yarı");
        }
        }
    }
}