using System;
using System.Linq;

namespace AvniSorular
{
    /* trabzon kelimesinin harfleriyle oluşturulabilecek 3 harfli kelimeler */
    class Permutasyon
    {
        public static void Main()
        {
            string str = "trabzon";
            var sorgu = from a in str
                        from b in str
                        from c in str
                        select "" + a + b + c;

            foreach (var element in sorgu)
            {
                Console.WriteLine(element);
            }
        }
    }
}
