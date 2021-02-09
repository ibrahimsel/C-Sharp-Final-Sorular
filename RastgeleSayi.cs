using System;
using System.Linq;
/*
 * Rastgele sayılar üretilecek.
 * Klavyeden girilen 6 basamaklı bir sayının ilk 2 basamağının
 * 10 katı üretilecek sayı âdetini, ikinci ve üçüncü ikişer basamakları ise 
 * üretilecek sayı aralığının alt ve üst sınırlarını gösterecektir.
 * İşlem bittikten sonra her sayıdan kaç adet üretildiğini satır satır "*" ile 
 * gösteriniz. Bu soruda TC Kimlik numaranızın ilk 6 hanesini girdi olarak
 * kullanınız. En çok üretilen sayısı en son satırda ifade ediniz.
 */

namespace AvniSorular
{
    class RastgeleSayi
    {
        public static void Main()
        {
            int alt_limit;
            int ust_limit;
            int uretilecek_adet;
            int n, m;
            
            Random rand = new Random();
            Console.WriteLine("TCKN'nizin ilk 6 hanesini giriniz: ");

            string str = Console.ReadLine();
            uretilecek_adet = Convert.ToInt32(str.Substring(0, 2)) * 10;  // ilk iki karakter * 10
            n = Convert.ToInt32(str.Substring(2, 2));  // 2. ikişer
            m = Convert.ToInt32(str.Substring(4, 2));  // 3. ikişer
            if (n > m)  // 2. ikişer 3. ikişerden büyük mü kontrolü yaparız ve alt limiti ona göre belirleriz
            {
                alt_limit = m;
                ust_limit = n;
            }
            else
            {
                alt_limit = n;
                ust_limit = m;
            }

            int[] uretilen_sayilar = new int[uretilecek_adet];  // üreteceğimiz sayıları saklayacağımız diziyi başlatıyoruz

            for (int i = 0; i < uretilecek_adet; i++)  // rastgele sayıları üretiyoruz
            {
                uretilen_sayilar[i] = rand.Next(alt_limit, ust_limit);
            }

            var kume = uretilen_sayilar.Distinct().ToArray();  // görüntü kirliliği olmaması için 
                                                               // her sayıdan kaç tane olduğunu bir kez
                                                               // yazdırıyoruz

            for (int i = 0; i < kume.Length; i++)  // sonucu görüntülüyoruz
            {
                var kere = uretilen_sayilar.Count(e => e == kume[i]);
                string sonuc = new string('*', kere);
                Console.WriteLine(kume[i] + ": " + sonuc);
            }
        }
    }
}
