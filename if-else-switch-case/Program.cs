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
        switch (time)
        {
            case 1:System.Console.WriteLine(time+".ay");break;
            case 2:System.Console.WriteLine(time+".ay");break;
            case 3:System.Console.WriteLine(time+".ay");break;
            case 4:System.Console.WriteLine(time+".ay");break;
            case 5:System.Console.WriteLine(time+".ay");break;
            case 6:System.Console.WriteLine(time+".ay");break;
            case 7:System.Console.WriteLine(time+".ay");break;
            case 8:System.Console.WriteLine(time+".ay");break;
            case 9:System.Console.WriteLine(time+".ay");break;
            case 10:System.Console.WriteLine(time+".ay");break;
            case 11:System.Console.WriteLine(time+".ay");break;
            case 12:System.Console.WriteLine(time+".ay");break;
            default:break;
        }
        
        
        
        }
    }
}