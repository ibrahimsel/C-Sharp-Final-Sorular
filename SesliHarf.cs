using System;

/* Klavyeden girilen bir kelimede hiç sesli harf yoksa (bcd) veya 
 * bütün harfler sesli ise (aeıi) kelimenin tekrar girilmesini
 * isteyen program */
namespace AvniSorular
{
    class SesliHarf
    {
        public static void Main()
        {
            string str;
            char[] sesli_harfler = new[] { 'a', 'A', 'e', 'E', 'ı', 'I', 'i', 'İ', 'o', 'O', 'ö', 'Ö', 'u', 'U', 'ü', 'Ü' };
            int sesli_sayaci;

            while (true)
            {
                sesli_sayaci = 0;
                Console.WriteLine("Lütfen bir kelime giriniz: ");
                str = Console.ReadLine();
                foreach (char harf in str)
                {
                    if (Array.Exists(sesli_harfler, x => x == harf))  // şu anki harf sesli harfler listesinde var mı kontrolü
                        sesli_sayaci += 1;  // varsa sayacı arttır
                }

                if (sesli_sayaci == 0 || sesli_sayaci == str.Length)  // Hiç sesli harf yoksa veya bütün harfler sesli ise
                    continue;
                else
                    break;
            }
        }
    }
}
