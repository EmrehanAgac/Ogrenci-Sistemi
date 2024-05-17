using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240129_GenelAlistirma
{
    public class Menu
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public static void Islemler(ConsoleKey cevap)
        {
            Console.Clear();
            switch (cevap)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Ekle("ÖĞRENCİ EKLE");
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Listele("ÖĞRENCİLERİ LİSTELE");
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Sil("ÖĞRENCİ SİL");
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Ortalama("ÖĞRENCİLERİN GENEL NOT ORTALAMASI");
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    YasOrtalamasi("ÖĞRENCİLERİN YAŞ ORTALAMASI");
                    break;
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                    if (ogrenciler.Any())
                    {
                        BaslikYazdir("TOPLAM ÖĞRENCİ SAYISI");
                        AnaMenuyeDon(string.Format("Toplam {0} öğrenci kayıtlıdır", ogrenciler.Count));
                    }
                    else
                        AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
                    break;
            }
        }

        private static void YasOrtalamasi(string v)
        {
            #region Any() Metodu
            // Any() metodu koleksiyon içerisinde eleman var mı yok mu sorusunu sorar. Geriye bool tipinde değer döndürür. Koleksiyon içerisinde eleman varsa "true" yoksa "false" değer döndürür.
            #endregion
            BaslikYazdir(v);
            int toplamYas = 0;
            foreach (var item in ogrenciler)
            {
                toplamYas += item.Yas;
            }
            double yasOrtalamasi = (double)toplamYas / ogrenciler.Count;
            AnaMenuyeDon(string.Format("Toplam {0} öğrencinin yaş ortalaması {1}", ogrenciler.Count, Math.Round(yasOrtalamasi, 2)));
        }

        private static void Ortalama(string v)
        {
            #region Any() Metodu
            // Any() metodu koleksiyon içerisinde eleman var mı yok mu sorusunu sorar. Geriye bool tipinde değer döndürür. Koleksiyon içerisinde eleman varsa "true" yoksa "false" değer döndürür.
            #endregion
            if (ogrenciler.Any())
            {
                BaslikYazdir(v);
                double genelToplam = 0;
                foreach (var item in ogrenciler)
                {
                    genelToplam += item.Ortalama;
                }
                double genelOrtalama = genelToplam / ogrenciler.Count;
                AnaMenuyeDon(string.Format("Toplam {0} öğrencinin genel not ortalaması {1}", ogrenciler.Count, Math.Round(genelOrtalama, 2)));
            }
            else
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
        }

        private static void Sil(string v)
        {
            #region Any() Metodu
            // Any() metodu koleksiyon içerisinde eleman var mı yok mu sorusunu sorar. Geriye bool tipinde değer döndürür. Koleksiyon içerisinde eleman varsa "true" yoksa "false" değer döndürür.
            #endregion
            if (ogrenciler.Any())
            {
                BaslikYazdir(v);
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                int siraNo = Metodlar.GetInt("Silmek istediğiniz öğrencinin sıra numarasını giriniz: ", 1, ogrenciler.Count);
                int indexNo = siraNo - 1;
                Console.Write(ogrenciler[indexNo].TamAd + " öğrencisini silmek istediğinize emin misiniz?(e) ");
                if (Console.ReadKey().Key == ConsoleKey.E)
                {
                    string silinen = ogrenciler[indexNo].TamAd;
                    ogrenciler.RemoveAt(indexNo);
                    AnaMenuyeDon(string.Format("{0} isimli öğrenci listeden başarı ile silindi", silinen));
                }
                else
                    AnaMenuyeDon("Silme işlemi iptal edildi");
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
            }

        }

        private static void Listele(string v)
        {
            #region Any() Metodu
            // Any() metodu koleksiyon içerisinde eleman var mı yok mu sorusunu sorar. Geriye bool tipinde değer döndürür. Koleksiyon içerisinde eleman varsa "true" yoksa "false" değer döndürür.
            #endregion
            if (ogrenciler.Any())
            {
                BaslikYazdir(v);
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                AnaMenuyeDon(string.Format("Toplam {0} öğrenci listelenmiştir", ogrenciler.Count));
            }
            else
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
        }



        private static void Ekle(string v)
        {
            BaslikYazdir(v);
            Ogrenci o = new();
            o.Ad = Metodlar.GetString("Adı Giriniz: ",2,20);
            o.Soyad = Metodlar.GetString("Soyadı Giriniz: ", 2, 20);
            o.N1 = Metodlar.GetDouble("1. Not: ", 0, 100);
            o.N2 = Metodlar.GetDouble("2. Not: ", 0, 100);
            o.DogumTarihi = Metodlar.GetDateTime("Doğum Tarihi: ", DateTime.Now.Year - 30, DateTime.Now.Year - 20);
            ogrenciler.Add(o);
            AnaMenuyeDon(string.Format("{0} öğrencisi listeleye başarıyla eklendi", o.TamAd));
        }

        private static void AnaMenuyeDon(string v)
        {
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basınız");
            Console.ReadKey();
        }

        private static void BaslikYazdir(string v)
        {
            Console.WriteLine(v);
            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }
    }
}
