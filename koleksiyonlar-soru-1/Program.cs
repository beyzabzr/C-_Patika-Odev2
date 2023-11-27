using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static void Main()
        {
            // Kullanicidan alinan 20 pozitif sayinin asal olup olmadigini ve asal olanlar, asal olmayan sayilarin kac adet oldugunu gosteren program

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Lutfen {i + 1}. pozitif sayiyi giriniz: ");
                if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
                {
                    if (IsAsal(sayi))
                    {
                        asalSayilar.Add(sayi);
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(sayi);
                    }
                }
                else
                {
                    Console.WriteLine("Gecerli bir pozitif sayi girmediniz. Lutfen tekrar deneyin.");
                    i--;
                }
            }

            //Elemanları buyukten kucuge siralayip yazdirma
            asalSayilar.Sort();
            asalSayilar.Reverse();
            Console.WriteLine("Asal Sayilar: ");
            PrintList(asalSayilar);

            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
            Console.WriteLine("\nAsal Olmayan Sayilar: ");
            PrintList(asalOlmayanSayilar);

            Console.WriteLine($"\n\nAsal sayilar listesi eleman sayisi: {asalSayilar.Count}");
            Console.WriteLine($"Asal olmayan sayilar listesi eleman sayisi: {asalOlmayanSayilar.Count}");

            //Ortalama 
            double asalOrtalama = 0;
            if (asalSayilar.Count > 0)
            {
                double toplamAsal = 0;
                foreach (var sayi in asalSayilar)
                {
                    if (sayi is int)
                    {
                        toplamAsal += (int)sayi;
                    };
                }
                asalOrtalama = toplamAsal / asalSayilar.Count;
            }

            double asalOlmayanOrtalama = 0;
            if (asalOlmayanSayilar.Count > 0)
            {
                double toplamAsalOlmayan = 0;
                foreach (var sayi in asalOlmayanSayilar)
                {
                    if (sayi is int)
                    {
                        toplamAsalOlmayan += (int)sayi;
                    };
                };
                asalOlmayanOrtalama = toplamAsalOlmayan / asalOlmayanSayilar.Count;
            }

            Console.WriteLine($"Asal sayilar listesi ortalama: {asalOrtalama}");

            Console.WriteLine($"Asal olmayan sayilar listesi ortalama: {asalOlmayanOrtalama}");
        }

        static bool IsAsal(int sayi)
        {
            if (sayi < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}