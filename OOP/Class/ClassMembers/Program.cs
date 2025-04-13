/*
 ---------- Class(Sınıf) nedir? ----------

    1- Kodları organize etmek için kullanılan bir yapıdır.
    2- İçinde özellikler(fields/properties) ve davranışlar(metotlar) barındırabilir.
    3- OOP'nin temelini oluşturur.
    4- Nesne ve referans oluşturmamız sağlayan yapılardan oluşur. Oluşturulan her sınıf "referans tipli değişken" olarak nitelendirilir.

    Özet olarak, class bir şablon oluşturur ve bu şablondan nesne(object) elde edilir.
*/

public class Program
{
    // Proje çalışırken ilk önce ana metot çalışır
    public static void Main()
    {
        Okul o = new Okul();
        o.Ad = "Namık Kemal Anadolu Lisesi";
        o.Sehir = "İstanbul";
        o.Yas = 25;
        // Output the values
        Console.WriteLine($"Okul Adı: {o.Ad}\nŞehir: {o.Sehir}");
    }
    // ---------- Field Kullanımı ----------

    public class Ogrenci()
    {
        public string? Ad; // Eğer veri tipinin sonuna soru işareti koyarsan kullanıcıya "Burası boş geçilebilir bir alan olabilir" demektir. Yani soru işareti bir alan isminin null olmasını da sağlayabilir.
        private int Yas;
    }
    // ---------- Property Kullanımı ----------
    public class Ogrenci2() //Üst Class
    {
        public int Id { get; set; }
        public string Ad { get; set; } // prop yazıp tab tuşuna bastığımızda bu yapı oluşur ve düzeltmen gereken yerleri düzelterek kullanabilirsin.
        public int Yas { get; set; } // prop yazıp tab tuşuna bastığımızda bu yapı oluşur ve düzeltmen gereken yerleri düzelterek kullanabilirsin.

        public List<Ogretmen> Ogretmenler { get; set; }
    }


    /* ---------- Inheritence(Kalıtım) Kullanımı ----------

        Bir sınıfın başka bir sınıfın özellklerini ve metotlarını miras almasıdır. Kod tekrarını azaltır, yapıların genişletilmesi kolaylaştırır.
        Eğer kod tekrarını gerektirecek bir durum yoksa bir üst sınıfa(abstract class) ihtiyaç duyulmaz.

    */

    // Eğer "Ogrenci2" sınıfındaki property'leri ya da varsa metotları kulanmak istersek aşağıdaki gibi "Ogrenci2" class'ını miras almamız gerekir.


    public class Okul : Ogrenci2 //Burada "Ogrenci2" sınıfını miras olarak kullandık.
    {
        public string Sehir { get; set; }
    }

    public class Ogretmen : Ogrenci2
    {
        public string Brans { get; set; }
    }
}


