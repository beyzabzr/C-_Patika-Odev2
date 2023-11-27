using System;
using System.Collections;
namespace koleksiyonlar_soru_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Kullanicidan alinan 20 sayinin en kucuk 3 ve en buyuk uc sayiyi bulup ayrı ayrı ortalamalarini alan ve ortalamalarin toplamini da ekrana yazdiran program

            ArrayList sayiListesi = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Lutfen {i + 1}. sayiyi giriniz: ");
                if (int.TryParse(Console.ReadLine(), out int sayi))
                {
                    sayiListesi.Add(sayi);
                }
                else
                {
                    Console.WriteLine("Gecersiz sayi girdiniz. Tekrar deneyiniz: ");
                    i--;
                }
            }

            int[] sayiDizisi = (int[])sayiListesi.ToArray(typeof(int));
            Array.Sort(sayiDizisi);
            ArrayList kucukUcSayi = new ArrayList();
            ArrayList buyukUcSayi = new ArrayList();

            for (int i = 0; i < Math.Min(3, sayiDizisi.Length); i++)
            {
                kucukUcSayi.Add(sayiDizisi[i]);
            }

            Console.Write("\nKucuk Uc Sayi: ");
            foreach (var sayi in kucukUcSayi)
            {
                Console.Write($"{sayi} ");
            }

            for (int i = Math.Max(0, sayiDizisi.Length - 3); i < sayiDizisi.Length; i++)
            {
                buyukUcSayi.Add(sayiDizisi[i]);
            }

            Console.Write("\nBuyuk Uc Sayi: ");
            foreach (var sayi in buyukUcSayi)
            {
                Console.Write($"{sayi} ");

            }

            double kucukUcSayiOrt = 0;
            if (kucukUcSayi.Count > 0)
            {
                double toplamKucuk = 0;
                foreach (var sayi in kucukUcSayi)
                {
                    if (sayi is int)
                    {
                        toplamKucuk += (int)sayi;
                    }
                }
                kucukUcSayiOrt = toplamKucuk / kucukUcSayi.Count;
            }
            Console.WriteLine($"\nEn Kucuk Uc Sayi Ortalama:  {kucukUcSayiOrt}");

            double buyukUcSayiOrt = 0;
            if (buyukUcSayi.Count > 0)
            {
                double toplamBuyuk = 0;
                foreach (var sayi in buyukUcSayi)
                {
                    if (sayi is int)
                    {
                        toplamBuyuk += (int)sayi;
                    }
                }
                buyukUcSayiOrt = toplamBuyuk / kucukUcSayi.Count;
            }
            Console.WriteLine($"En Buyuk Uc Sayi Ortalama:  {buyukUcSayiOrt}");

            Console.WriteLine($"Ortalama Toplamlari : {buyukUcSayiOrt + kucukUcSayiOrt}");
        }
    }
}