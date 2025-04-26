using Technology.Entities.Abstract;

namespace Technology.Entities.Concrete
{
    public class Bilgisayar : ElektronikCihaz //Bilgisayar, elektronik sınıfından türetilmiş bir sınıftır.
    {
        //public int Id { get; set; }
        //public string? Marka { get; set; } //Soru işareti buranın boş geçilebilir olduğunu belirtir.
        //public string Model { get; set; }
        public string Klavye { get; set; }
        public override void BilgileriYazdir() 
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Klavye Türü: {Klavye}");
        }
    }
}
