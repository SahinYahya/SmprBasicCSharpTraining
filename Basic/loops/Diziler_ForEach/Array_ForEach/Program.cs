// --------------------Array and ForEach------------------------

// Array(Liste): C#'ta bir dizi tutmak için kullanılır.
// Veri_tipi[] collection = new veri_tipi[dizi_boyutu]

/*
int a = 5;
int b = 6;
int c = 7;
int d = 8;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
*/

// Örnek: Bir kaç tane değeri farklı değişkenlerde tutmak yerine bir listede tutabiliriz.

/*
int[] sayilar = [5,6,7,8];
Console.WriteLine(sayilar);

*/

// Veri_tipi[] collection = new veri_tipi[dizi_boyutu]


/*
int[] numbers = new int[5];
// indeksleme ile listeyi ekrana tazdırma
numbers[0] = 1; //index 0'dan başlar.
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;
Console.WriteLine("numbers listesinin elemanları:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i}.index: {numbers[i]}");
}

*/


// foreach ile bir listenin elemanlarını ekrana yazdırma

string[] ogrenciler = { "İsmail", "Hüseyin", "Sezer", "Bayram", "Coşkun" };
Console.WriteLine("----------11A Öğrencileri----------");
foreach (string ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}