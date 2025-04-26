/* Class Members and OOP : Inheritence, Base Class(Temel Sınıf - Soyut Sınıf - Abstract Class),
 * Derived Class(Türemiş sınıf), virtual method and override method.
 

//Inheritence( Kalıtım alma (Miras alma) anlamına gelir. Temel (üst sınıfın) bir sınıfın tüm özelliklerini ve varsa metotlarını kullanabilmel için inherit etme yani kalıtım alma.

*/


// Örnek : Üst sınıfı kalıtım almak. Aslında etmelinde DRY var yani Dont Repeat Yourself(Kendini tekrar etme) prensibi var.
// Amaç tekrar eden kodları alanda toplayıp onları herhangi bir yerden miras
class Hayvan
{
    public int Id { get; set; } //ID uniq yani benzersiz bir identity(Kimlik)
    public string Name { get; set; }
    public virtual void SesCikarir() //Virtual olam metotlar başka bi ryerde override edilebilir.
    {
        Console.WriteLine("Hayvan Ses Çıkarır.");
    }
}

//Aşağıdaki Classların hepsi Hayvan Classından türetilmiştir.
class Kedi : Hayvan
{
    public void Miyavla()
    {
        Console.WriteLine($"{Name} miyavlıyor.");
    }
    public override void SesCikarir()
    {
        base.SesCikarir();
    }
}

class Köpek : Hayvan
{
    public void Havla()
    {
        Console.WriteLine($"{Name} havlıyor.");
    }
    public override void SesCikarir()
    {
        base.SesCikarir();
    }
}

class Kuş : Hayvan
{
    public void Havla()
    {
        Console.WriteLine($"{Name} uçuyor.");
    }
    public override void SesCikarir()
    {
        base.SesCikarir();
    }
}