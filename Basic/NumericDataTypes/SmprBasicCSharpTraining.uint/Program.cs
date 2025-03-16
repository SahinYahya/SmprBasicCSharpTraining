namespace SmprBasicCSharpTraining.uint2;

internal class Program
{
    private static void Main(string[] args)
    {
        // uint, c# dilinde "unsigned integer" yani "işaretsiz tam sayı" anlamına gelir. int veri tipi negatif ve pozitif tam sayı alırken , uint yalnızca pozitif tam sayı değerlerini tutar.
        // bellek boyutu: 4 bayt(32 bit)
        // değer aralığı 0 ile 4294967295 arasında değer alır.

        uint maxValue = uint.MaxValue;
        uint minValue = uint.MinValue;
        Console.WriteLine($"uint max value: {maxValue}\nuint min value: {minValue}");

        //doğru kullanımı
        uint a = 12;
        Console.WriteLine(a);

        //yanlış kullanımı
        //uint b = -14;
        //Console.WriteLine(b);// derleme hatası alırsınız.
    }
}