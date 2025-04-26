namespace Technology.Entities.Abstract
{
    public abstract class ElektronikCihaz //Base Clas (Temel Sınıf - Üst Sınıf)
    {
        public int Id { get; set; }
        public string? Marka { get; set; } //Soru işareti buranın boş geçilebilir olduğunu belirtir.
        public string Model { get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Id: {Id}\nMarka{Marka}\nModel{Model}");
        }
    }
}
