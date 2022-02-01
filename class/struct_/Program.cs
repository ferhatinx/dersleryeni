using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdötgen = new Dikdörtgen();
            dikdötgen.KisaKenar =3;
            dikdötgen.UzunKenar =5;

            System.Console.WriteLine(dikdötgen.Alan());

            Dikdörtgen_struct dik_Struct;
            dik_Struct.KisaKenar =4;
            dik_Struct.UzunKenar =4 ;


        }
    }
    class Dikdörtgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long Alan()
        {
            return this.KisaKenar * this.UzunKenar;
        }

    }
    struct Dikdörtgen_struct
    {
         public int KisaKenar;
        public int UzunKenar;

        public long Alan()
        {
            return this.KisaKenar * this.UzunKenar;
        }


    }
}