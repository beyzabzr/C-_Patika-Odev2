using System;
using System.Collections.Generic;

namespace koleksiyonlar_soru_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan program

            Console.Write("Bir Cumle Girin: ");

            string cumle = Console.ReadLine();
            char[] sesliHarfler = GetSesliHarfler(cumle);

            Array.Sort(sesliHarfler);

            Console.WriteLine("Siralanmis sesli harfler: ");
            foreach (var harf in sesliHarfler)
            {
                Console.Write(harf + " ");
            }
        }
        static char[] GetSesliHarfler(string cumle)
        {
            HashSet<char> sesliHarfler = new HashSet<char>();

            foreach (char harf in cumle)
            {
                if (IsSesliHarf(harf))
                {
                    sesliHarfler.Add(harf);
                }
            }
            return new List<char>(sesliHarfler).ToArray();
        }

        static bool IsSesliHarf(char harf)
        {
            return "aeuüiıoö".Contains(char.ToLower(harf));
        }
    }
}
