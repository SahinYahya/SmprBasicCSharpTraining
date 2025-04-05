// Dataları bir JSON dosyasına yazdırma ve okuma

using Newtonsoft.Json;

string dosyaAdi = "ogrenciler.json"; //JSON dosyasının adı
List<string> ogrenciler = new List<string>();

// Program başlarken kayıtlı öğrencileri yükle
OgrencileriYukle();
bool devam  = true; //while döngüsünü kontrol eden değişken

while (devam)
{
    Console.WriteLine("==== Öğrenci Yönetim Uygulaması ====");
    Console.WriteLine("1. Öğrenci Ekle");
    Console.WriteLine("2. Öğrenci Sil");
    Console.WriteLine("3. Öğrenci Güncelle");
    Console.WriteLine("4. Öğrencileri Listele");
    Console.WriteLine("5. Çıkış");

    Console.Write("Seçiminizi yapın: ");
    int secim = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan bir input alınır.

    switch (secim)
    {
        case 1: // Öğrenci ekle
            Console.WriteLine("Eklemek İstediğiniz Öğrencinin Adını Giriniz: ");
            string yeniOgrenci = Console.ReadLine(); // input
            ogrenciler.Add(yeniOgrenci);
            OgrencileriKaydet(); //JSON dosyasını kaydet. İlk kayıtla birlikte JSON dosyası oluşmuş oluyor.
            Console.WriteLine($"{yeniOgrenci} adlı öğrenci başarıyla eklendi.");
            break;
        case 2: // Öğrenci sil
            Console.WriteLine("Silmek İstediğiniz Öğrencinin Adını Giriniz: ");
            string silinecekOgrenci = Console.ReadLine(); // input
            if (ogrenciler.Remove(silinecekOgrenci))
            {
                Console.WriteLine($"{silinecekOgrenci} adlı öğrenci başarıyla silindi.");
                OgrencileriKaydet(); //Dosyayı son haliyle kaydeder.
            }
            else
            {
                Console.WriteLine($"{silinecekOgrenci} adlı öğrenci bulunamadı");
            }
            break;
        case 3: //Öğrenci güncelle
            Console.WriteLine("Güncellemek İstediğiniz Öğrencinin Adını Giriniz: ");
            string eskiAdi = Console.ReadLine();
            if (ogrenciler.Contains(eskiAdi))
            {
                Console.WriteLine("Yeni İsmi Giriniz: ");
                string yeniAdi = Console.ReadLine();
                int index = ogrenciler.IndexOf(eskiAdi);
                ogrenciler[index] = yeniAdi;
                Console.WriteLine($"Öğrenci '{eskiAdi}' adı '{yeniAdi}' olarak güncellendi ");
                OgrencileriKaydet(); //Dosyayı son haliyle kaydeder.
            }
            else
            {
                Console.WriteLine($"Öğrenci {eskiAdi} bulunamadı.");
            }
            break;
        case 4: // Öğrenci listeleme
            Console.WriteLine("\nÖğrenci Listesi: ");
            if (ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede Öğrenci Yok");
            }
            else
            {
                int counter = 0;
                foreach (var ogrenci in ogrenciler)
                {
                    counter++;
                    Console.WriteLine($"{counter} - {ogrenci}");
                }
            }
            break;
        case 5:
            devam = false;
            Console.WriteLine("Çıkış Yapılıyor...");
            break;
        default:
            Console.WriteLine("\nYanlış bir seçim yaptınız! 1-5 arasında değer girin.");
            break;

    }
}
//JSON dosyasına öğrenci listesini kaydetme fonksiyonu.
void OgrencileriKaydet()
{
    string json = JsonConvert.SerializeObject(ogrenciler,Formatting.Indented); //Dosyayı JSON formatına dönüştürür.
    File.WriteAllText(dosyaAdi, json); //JSON'ı dosyaya yaz
}

//JSON dosyasından öğrenci listesini yükleme fonksiyonu.
void OgrencileriYukle()
{
    if (File.Exists(dosyaAdi)) //dosya varsa
    {
        string json = File.ReadAllText(dosyaAdi); //JSON'ı oku
        ogrenciler = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string> ();
    }
    else
    {
        string mesaj = "Liste yok";
        Console.WriteLine(mesaj);
    }
}