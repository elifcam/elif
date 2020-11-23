using System;
class Dikdortgen
{
    static int AlanHesapla(int b, int h)
    {
        int alan = b * h;
        return alan;
    }
    static int CevreHesapla(int b, int h)
    {
        int cevre = 2 * (b + h);
        return cevre;
    }
    static void Main()
    {
        Console.WriteLine("Kısa kenarı giriniz.");
        int kk = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Uzunkenarı giriniz.");
        int uk = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Alanı {0}", AlanHesapla(kk, uk));
        Console.WriteLine("Dikdörtgenin Çevresi {0}", CevreHesapla(kk, uk));
        Console.ReadKey();
    }
}
