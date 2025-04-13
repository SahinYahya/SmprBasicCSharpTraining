// Ogrenci App : Öğrenci CRUD operation.
// Algoritma :
// 1- class kullanmadan "Ogrenci"(record) aında bir nesne tutsun. Bu nesnenin adı, soyadın ve numarası olsun. Erişim belirleyicisi public olsun.
// 2- static bir class oluşturalım adı da "Uygulama" olsun.
// 3- Uygulama classı içerisinde kayıtları tutmak için ogrenciler.json adında bir dosya adı oluşturalım.
// 4- Uygulama classının içerisinde bir ana metot(Main) oluşturalım.
// 5- Eğer JSON dosyası varsa ve içerisinde kayıtlar varsa en başta ana metodun içerisinde DosyadanOku() adındaki metodu çağıralım.
// 6- while döngüsü için bir boolean oluşturalım. (bool devam = true;)
// 7- Bir while döngüsü oluştuır. Ekle, Listele, Sil, Güncele, Çıkış(CRUD). Kullanıcıdan bir seçim yapmasını iste.
// Burada switch-case yerine karar yapısını kullanalım. Karar yapısı kod bloklarında sadece metotları çağıracağımız için
// bütün CRUD işlemlerini sorumlu olan metotlarda yapacağız.
// 8- 



using System;
using System.Threading.Channels;
using Newtonsoft.Json;

public record Ogrenci(string Adı, string Soyadı, int No);

static class Uygulama
{
    static string dosyaAdi = "ogrenciler.json";
    static List<Ogrenci> ogrenciler = new();
    public static void Main()
    {
        DosyadanOku();
        bool devam = true;
        while (devam)
        {
            Console.WriteLine("\n-----Öğrenci İşlemleri-----");
            Console.WriteLine("1-Öğrenci Ekle");
            Console.WriteLine("2-Öğrenci Listele");
            Console.WriteLine("3-Öğrenci Sil");
            Console.WriteLine("4-Öğrenci Güncelle");
            Console.WriteLine("0-Çıkış");

            Console.WriteLine("Bir Seçim Yapınız:");
            string secim = Console.ReadLine();

            if (secim == "1") OgrenciEkle();

            else if (secim == "2") OgrenciListele();

            else if (secim == "3") OgrenciSil();

            else if (secim == "4") OgrenciGuncelle();

            else if (secim == "0") devam = false;

            else Console.WriteLine("Geçersiz Seçim!");


        }

    }

    static void OgrenciEkle()
    {
        Console.Write("Öğrenci Adı: ");
        string adi = Console.ReadLine();

        Console.Write("Öğrenci Soyadı: ");
        string soyadi = Console.ReadLine();

        Console.Write("Öğrenci Numarası: ");
        int ogrenciNo = Convert.ToInt32(Console.ReadLine());

        ogrenciler.Add(new Ogrenci(adi, soyadi, ogrenciNo));
        DosyayaYaz();
    }

    static void OgrenciListele()
    {
        Console.WriteLine("\n--- Öğrenci Listesi ---");
        foreach (var ogrenci in ogrenciler)
            Console.WriteLine($"Adı: {ogrenci.Adı}, Soyadı: {ogrenci.Soyadı}, Öğrencinin Numarası: {ogrenci.No}");
    }
    static void OgrenciSil()
    {
        Console.WriteLine("Silinecek Öğrenci No: ");
        int no = Convert.ToInt32(Console.ReadLine());

        var ogrenci = ogrenciler.Find(o => o.No == no);
        if (ogrenci != null)
        {
            ogrenciler.Remove(ogrenci);
            DosyayaYaz();
            Console.WriteLine("Öğrenci Başarıyla Silindi");
        }
    }
    static void OgrenciGuncelle()
    {
        Console.WriteLine("Güncellenecek Öğrenci No: ");
        int no = Convert.ToInt32(Console.ReadLine());

        var index = ogrenciler.FindIndex(o => o.No == no);
        if (index >= 0)
        {
            Console.Write("Yeni Adı: ");
            string yeniAd = Console.ReadLine();
            Console.Write("Yeni Soyadı: ");
            string yeniSoyadi = Console.ReadLine();

            ogrenciler[index] = new Ogrenci(yeniAd, yeniSoyadi, no);
            DosyayaYaz();
            Console.WriteLine("Öğrenci başarıyla güncellendi.");

        }
        else Console.WriteLine("Öğrenci bulunamadı!");

    }

    static void DosyayaYaz()
    {
        File.WriteAllText(dosyaAdi, JsonConvert.SerializeObject(ogrenciler, Formatting.Indented));
    }
    static void DosyadanOku()
    {
        if (File.Exists(dosyaAdi))
        {

            string json = File.ReadAllText(dosyaAdi);
            ogrenciler = JsonConvert.DeserializeObject<List<Ogrenci>>(json) ?? new List<Ogrenci>();

        }
    }
}

