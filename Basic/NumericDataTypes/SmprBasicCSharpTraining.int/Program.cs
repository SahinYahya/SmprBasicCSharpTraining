// ------------------int data type--------------
// C# dilinde en çok kullanılan veri tiplerinden biridir. Bu veri tipi tam sayıları temsil eder.
// int, "integer" kelimesinin kısatılmış halidir.
// 32 bitlik(4 byte => 1 byte = 8 bit) bir yer kaplar.
// Bu veri tipi genellikle döngülerde, hesaplamalarda veya sayısal işlemlerde kullanılır.
// değer aralığı -2147483648 ile  2147483647

//int max value
int maxValue = int.MaxValue;
Console.WriteLine("int data type max value: " + maxValue);

// int min value
int minValue = int.MinValue;
Console.WriteLine($"int data type min value: {minValue}");

//int veri tipi hem negatif hem pozitif sayıları barındırır.
int negatifSayi = -5;
int pozitifSayi = 5;
Console.WriteLine($"negatif sayı: {negatifSayi}\npozitif sayı: {pozitifSayi}");

// int veri tipiyle işlem yapma
int a = 5;
int b = 10;
int toplam = a + b;
Console.WriteLine($"a + b = {toplam}");

int c = 12;
int d = 10;
// değişken tanımlamadan c ve d'yi toplama
Console.WriteLine($"\ndeğişken tanımlamadan c ve d'yi toplama: {c + d}");

// soru: x ve y değişkeni tanımlayıp ortalamasını alınız.
// 1.adım: x ve y değişkeni tanımla, değer atamalarını yap.
// 2. bu iki değişkeni topla.
// 3.adım: toplamın ortalamasını al.
// 4. iki sayının ortalamasını ekrana yazdır.
int x = 5;
int y = 13;
int sum = x + y;
int ortalama = sum / 2; //1.yöntem
int ortalama2 = (x + y) / 2;//2.yöntem
Console.WriteLine($"x ve y'nin ortalaması: {ortalama}");

//overflow(değer taşması)
//int overflow = 2147483648;