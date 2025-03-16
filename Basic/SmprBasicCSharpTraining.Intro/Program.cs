// See https://aka.ms/new-console-template for more information

//1.Console.WriteLine ve Console.Write kullanımı.
//Console.WriteLine("Hello, World!");
//Console.Write("Hello, ");
//Console.Write("World!");

//Console bir class'tır. WriteLine ve Write ise bu class'ın metotlarıdır. WriteLine metodu, ekrana yazdırılan metni yazdırır ve bir alt satıra geçer. Write metodu ise ekrana yazdırılan metni yazdırır ve aynı satırda kalır.

//2. Değişken(variable) tanımlama ve kullanımı.
// dataType variableName = value;
string name = "John";
int elmaSepeti = 5;
Console.WriteLine(name);
Console.WriteLine(elmaSepeti);

// Birleştirme(+) op. ile John ve  5 değerini aynı satırda yazdıralım.
Console.WriteLine(name + " " + elmaSepeti);
//İki farklı değişkeni aynı satırda kullanma
string hello = "Hello, ";
string world = "World";
Console.WriteLine(hello + world);

Console.WriteLine("Hello ve World kelimesinin birleşimi: " + hello + world);
// string interpolation kullanımı
Console.WriteLine($"Hello ve World kelimesinin birleşimi: {hello + world}");

// Soru: Değişken tanımlayarak, Benim adım Cüneyt Kaya, 28 yaşındayım. Bu cümleyi yazdırınız.
string info = "Benim adım";
string adSoyad = "Cüneyt Kaya";
int yas = 28;
Console.WriteLine($"{info} {adSoyad}, {yas} yaşındayım.");

//3.C# dilinde aynı isimde değişkeni birden fazla kez tanımlayamayız.
//string ad = "Cüneyt";
//string ad = "Ahmet";

//4.Değişken tanımlarken özel karakterler kullanamayız.
//string ad soyad = "Cüneyt Kaya"; //Hatalı kullanım: ad ve soyad arasında boşluk olmamalıdır.
//string ad_Soyad = "Cüneyt Kaya";//Doğru kullanım.
//int 1sayi = 25; //Hatalı kullanım: Değişken ismi sayı ile başlayamaz.
//int sayi1 = 25; //Doğru kullanım.

//5.Değişken isimlerinde büyük-küçük harf duyarlılığı vardır.
string ad = "Cüneyt";//Doğru kullanım.
string Ad = "Kaya";//Yanlış kullanım.

//6.Türkçe karakter kullanılamaz.
int dört = 4; //Yanlış kullanım.
int dort = 4; //Doğru kullanım.

//7.Class kullarak hello world yazdırma
public class HelloWorld //public erişim belirleyicisi. Her yerden erişilebilir.
{
    private static void Main()
    {
        Console.WriteLine("Class Kullanarak: Hello, World!");
    }
}