using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a= 13;  
            for (int i = 0; i < a; i++)
            {
               if (i % 2 != 0)
               {
                  System.Console.WriteLine(i);
               }
               else
               {
                   continue;
                }
            }
            
        
        
        
        }
    }
}