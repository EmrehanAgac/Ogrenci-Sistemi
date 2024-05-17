// 1- ÖĞRENCİ EKLE // 
// 2- ÖĞRENCİLERİ LİSTELE
// 3- ÖĞRENCİ SİL
// 4- ÖĞRENCİLERİN GENEL NOT ORTALAMASI
// 5- ÖĞRENCİLERİN YAŞ ORTALAMASI
// 6- TOPLAM ÖĞRENCİ SAYISI
// 0- ÇIKIŞ

using _20240129_GenelAlistirma;

ConsoleKey cevap;
do
{
    Console.Clear();
    Console.WriteLine("ÖĞRENCİ KAYIT PROGRAMI");
    Console.WriteLine("----------------------");
    Console.WriteLine("1- Öğrenci Ekle");
    Console.WriteLine("2- Öğrencileri Listele");
    Console.WriteLine("3- Öğrenci Sil");
    Console.WriteLine("4- Öğrencilerin Genel Not Ortalaması");
    Console.WriteLine("5- Öğrencilerin Yaş Ortalaması");
    Console.WriteLine("6- Toplam Öğrenci Sayısı");
    Console.WriteLine("0- Çıkış");
    Console.WriteLine();
    Console.Write("Hangi İşlemi Yapmak İstersiniz? ");
    cevap = Console.ReadKey().Key;
    Menu.Islemler(cevap);
} while (cevap != ConsoleKey.NumPad0 && cevap != ConsoleKey.D0);

Console.WriteLine();
Console.WriteLine("Programı kullandığınız için teşekkür ederiz");
Console.WriteLine("Programı kapatmak için bir tuşa basınız");
Console.ReadKey();