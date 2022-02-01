using System;

class MainClass {

  

  static void Main() 
  {  
    ogrenci ogrenci1=new ogrenci("Ayşe",123,"discord");
    ogrenci1.bilgial();


  }
}
class ogrenci{
  private string ad;
  private int no;
  private string departman;
    public string Ad { get => ad; set => ad = value; }
    public int No {get => no; set => no = value;}
    public string Departman { get => departman; set => departman = value; }

    public ogrenci(string ad, int no, string departman)
    {
      this.Ad=ad;
      this.No=no;
      this.Departman=departman;
    }
    public ogrenci(){}

    public void bilgial()
    {
      System.Console.WriteLine("*******ogrenci bilgisi*****");
      System.Console.WriteLine("ogrenci ad: {0}",Ad);
      System.Console.WriteLine("ogrenci numarası:"+No);
      System.Console.WriteLine("departman:"+Departman);

    }






}





















