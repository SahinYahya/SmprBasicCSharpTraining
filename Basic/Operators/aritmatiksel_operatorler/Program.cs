//  C#'ta Aritmatiksel Operatörler, sayısal işlemler yapmak için kullanılır.

// 1.Toplama(+) Op.

// iki sayının toplamını ekrana yazdırma.
int sayi = 15;
int sayi2 = 20;
int toplam = sayi + sayi2;
Console.WriteLine($"sayi + sayi2 = {toplam}");

// 2.Çıkarma(-) Op.
int cikarma = sayi2 - sayi;
Console.WriteLine($"sayi2 - sayi = {cikarma}");

// 3.Çarpma(*) Op.
//iki sayının çarpımı
int carpma = sayi * sayi2;
Console.WriteLine($"sayi * sayi2 = {carpma}");

// 4.Bolme(/) Op.
int bolme = sayi2 / sayi;
Console.WriteLine($"sayi2 / sayi = {bolme}");

// 5.Mod alma: Bir sayının diğerine bölümünden kalan değeri bulmak için kullanılır.
int x = 25, y = 5;
int kalan = x % y;
Console.WriteLine($"x'in y'ye bölümünden kalan: {kalan}");
//Console.WriteLine("x'in y'ye bölümünden kalan:" + kalan);

//6.Artırma(++): bir değişkenin değerini 1 artırır.
int sayi3 = 4;
sayi3++;
Console.WriteLine("sayi3 yeni değeri: " + sayi3); //Çıktı:5

//7.Azaltma(--) Op: bir değişkenin değerini 1 azaltır.
int sayi4 = 4;
sayi4--;
Console.WriteLine("sayi4 yeni değeri: " + sayi4); //Çıktı:3

//Postfix(Sonra Artırma) ve Prefix(Önce Artırma)

//Postfix(Sonra Artırma) kullanımı: c++
int c = 5;
Console.WriteLine("c++ sonucu: " + (c++)); //önce yazdırır sonra artır.
Console.WriteLine("c sonucu: " + c);

//Prefix(Önce Artırma)
int d = 10;
Console.WriteLine("++d sonucu: " + (++d)); // önce artırır sonra yazdırır.