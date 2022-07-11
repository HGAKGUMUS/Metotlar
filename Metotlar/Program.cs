// See https://aka.ms/new-console-template for more information

using Metotlar;


string urunAdi1 = "Elma";
double fiyati1 = 15;
string aciklama1 = "amasya elması";


string urunAdi2 = "Çilek";
double fiyati2 = 10;
string aciklama2 = "çilek gibi çilek";



Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.Fiyati = 15;
urun1.Aciklama = "amasya elması";

Urun urun2= new Urun();
urun2.Adi = "karpuz";
urun2.Fiyati = 20;
urun2.Aciklama = "diyarbakırrr";

Urun[] urunler = new Urun[] { urun1, urun2 };

//type-safe
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("----------------");
}

Console.WriteLine("---------------Metotlar-----------"); 

 



SepetManager sepetManager= new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);











Console.ReadKey();