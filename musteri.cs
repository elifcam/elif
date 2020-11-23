using System;
class Musteri
{
    private string AdSoyad;
    private int Yas;
    private string Meslek;
    private int Maas;

    public string adsoyad
    {
        get
        {
            return AdSoyad;
        }
        set
        {
            AdSoyad = value;
        }
    }

    public int yas
    {
        get
        {
            return Yas;
        }
        set
        {
            Yas = value;
        }
    }
    public string meslek
    {
        get
        {
            return Meslek;
        }
        set
        {
           Meslek = value;
        }
    }
    public int maas
    {
        get
        {
            return Maas;
        }
        set
        {
            Maas = value;
        }
    }
}

class Program
{
    private static readonly string Aşçı;

    static void Main(string[] args)
    {
        Musteri m1 = new Musteri();
        m1.adsoyad = "Serdar Şahin"; 
        m1.yas = 32;
        m1.meslek = Aşçı;
        m1.maas = 5000;
        Console.WriteLine("Ad/Soyad:{0} - Yaş:{1} - Meslek:{2} - Maaş:{3}", m1.adsoyad, m1.yas, m1.meslek,m1.maas);
    }
}
