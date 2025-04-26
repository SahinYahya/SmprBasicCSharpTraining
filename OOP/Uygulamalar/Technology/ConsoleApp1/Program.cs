// Technology App : 

using System.ComponentModel.Design;
using System.Linq.Expressions;
using Technology.Entities.Abstract;
using Technology.Entities.Concrete;

class program
{
    List<ElektronikCihaz> devices = new List<ElektronikCihaz>();
    int IdSayaci = 1;
    static void Main()
    {
        var program = new program();
        program.Calistir();
    }
    public void Calistir()
    {
        while (true) 
        {
            Console.WriteLine("-----Teknoloji Uygulaması-----");
            Console.WriteLine("1 - Kayıt Ekle");
            Console.WriteLine("2 - Kayıt Sil");
            Console.WriteLine("3 - Kayıt Güncelle");
            Console.WriteLine("4 - Kayıt Listele");
            Console.WriteLine("0 - Çıkış");

            Console.WriteLine("Bir seçim yapınız");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1: KayitEkle(); break;
                case 2: KayitSil(); break;
                case 3: KayitGuncelle(); break;
                case 4: KayitListele(); break;
                case 0: return;
                //case 5: Cikis(); break;
                default: Console.WriteLine("Geçersiz seçim"); break;
            }

        }
    }
    void KayitEkle()
    {
        Console.WriteLine("Telefon için 1, Bilgisayar için 2: ");
        int secenek = int.Parse(Console.ReadLine());

        Console.Write("Marka: ");
        string marka = Console.ReadLine();

        Console.Write("Model: ");
        string model = Console.ReadLine();

        if (secenek == 1)
        {
            Console.Write("Sim Kart Özelliği: ");
            string sim = Console.ReadLine();

            devices.Add(new Telefon
            {
                Id = IdSayaci++,
                Marka = marka,
                Model = model,
                SimKart = sim

            });
        }
        else if (secenek == 2)
        {
            Console.Write("Klavye Türü: ");
            string KlavyeTuru = Console.ReadLine();

            devices.Add(new Bilgisayar
            {
                Id = IdSayaci++,
                Marka = marka,
                Model = model,
                Klavye = KlavyeTuru

            });
        }
        ClearData();

    }
    void KayitSil()
    {
        Console.WriteLine("Silinecel ID: ");
        int silinecekId = Convert.ToInt32(Console.ReadLine());

        //FirstOrDefault kullanımı
        var deviceId = devices.FirstOrDefault(d => d.Id == silinecekId);
        if (deviceId!=null)
        {
            devices.Remove(deviceId);
            Console.WriteLine("Kayıt başarıyla silindi...");
        }
        else
        {
            Console.WriteLine("Kayıt bulunamadı.");
        }
        ClearData();
    }

    void KayitGuncelle()
    {
        Console.WriteLine("Güncellenecek Cihazın ID: ");
        int guncellenecekId = Convert.ToInt32(Console.ReadLine());

        //FirstOrDefault kullanımı
        var deviceId = devices.FirstOrDefault(d => d.Id == guncellenecekId);

        if (deviceId != null)
        {
            Console.Write("Yeni Marka: ");
            deviceId.Marka = Console.ReadLine();

            Console.Write("Yeni Model: ");
            deviceId.Model = Console.ReadLine();

            if (deviceId is Telefon tel)
            {
                Console.WriteLine("Yeni Sim Özelliği: ");
                tel.SimKart = Console.ReadLine();
            }
            else if(deviceId is Bilgisayar bil)
            {
                Console.WriteLine("Yeni Klavye Türü: ");
                bil.Klavye = Console.ReadLine();
            }
            Console.WriteLine("İşlem başarılı");
        }
        ClearData();
    }

    void KayitListele()
    {
        if (devices.Count == 0) 
        {
            Console.WriteLine("Listede kayıt bulunamadı...");
        }
        foreach (var cihaz in devices) //devices listesindeki elemanları tek tek al.
        {
            cihaz.BilgileriYazdir();
        }
        ClearData();
    }
    //void Cikis()
    void ClearData()
    {
        Console.WriteLine("\nDevam etmek için bir tuşa basınız...");
        Console.ReadKey();
        Console.Clear();
    }
}