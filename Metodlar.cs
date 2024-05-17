using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240129_GenelAlistirma
{
    #region string.IsNullOrEmpty
    // string.IsNullOrEmpty() metodu, string değerin boş olup olmadığını kontrol eder. Geriye bool tipinde değer döndürür. Eğer string değer boş ise "true", değilse "false" döndürür.
    #endregion
    public class Metodlar
    {
        // Metodlar.GetString("Ad Giriniz: ");
        // Metodlar.GetString("Ad Giriniz: ", 2, 20);
        public static string GetString(string metin, int min = 1, int max = 500) // "Adı Giriniz: ",2,20
        {
            string txt = string.Empty; // boş bir string değer oluşturdum
            bool hata = false;
            do
            {
                Console.Write(metin);
                txt = Console.ReadLine();
                if (string.IsNullOrEmpty(txt))
                {
                    Console.WriteLine("Boş Bir Değer Giremezsiniz");
                    hata = true;
                }
                else
                {
                    if (txt.Length < min || txt.Length > max)
                    {
                        Console.WriteLine("Lütfen min. {0} max. {1} uzunlukta metin giriniz",min,max);
                        hata = true;
                    }else if (!IsOnlyLetters(txt.Replace(" ", "")))
                    {
                        Console.WriteLine("Lütfen sadece harf giriniz");
                        hata = true;
                    }
                    else
                    {
                        hata = false;
                    }
                }
            } while (hata);
            return txt;
        }

        private static bool IsOnlyLetters(string text) // Mahmut
        {
            foreach (var character in text)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }
            return true;
        }

        public static int GetInt(string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max) // 5 -- 15
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen {0} ile {1} arasında bir değer giriniz",min,max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        public static double GetDouble(string metin, double min = Double.MinValue, double max =Double.MaxValue) //"1. Not: ", 0, 100
        {
            
            double sayi = 0;
            bool hata = false;
            do
            {
                // o.N1 = Metodlar.GetString("1. Not: ",0,100);
                Console.Write(metin); // 1. Not: 
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen {0} ile {1} arasında bir değer giriniz",min,max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        public static DateTime GetDateTime(string metin, int minYear, int maxYear) //"Doğum Tarihi: ", DateTime.Now.Year - 30, DateTime.Now.Year - 20
        {
            DateTime date = DateTime.Now;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    date = DateTime.Parse(Console.ReadLine());
                    if (date.Year <= maxYear && date.Year >= minYear)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen {0} ile {1} yılları arasında bir tarih giriniz", minYear, maxYear);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return date;
        }
        
    }
}
