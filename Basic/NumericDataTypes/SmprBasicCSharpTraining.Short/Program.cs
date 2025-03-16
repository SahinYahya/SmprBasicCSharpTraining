// ------short data type---------------
// Değer aralığı: -32,768 ile 32767 arasındadır. Yani short veri tipi işaretli(signed) bir veri tipidir. hem pozitif hem de negatif değerleri tutabilir.

// Bellekte 2 byte(16 bit)'lık bir alan kaplamaktadır.

// byte data type variable = value;
short minValue = -32768;
short maxValue = 32767;

// string interpolation kullanımı: string format output.
//Console.WriteLine("short veri tipinin min değeri(normal kullanımı): " + minValue); //normal kullanımı
Console.WriteLine($"short veri tipinin min değeri(string interpolation kullanımı): {minValue}"); //string interpolation kullanımı.

Console.WriteLine($"short veri tipinin max değeri: {maxValue}");

// short veri tipinin max ve min value ispatı
short mindDeger = short.MinValue;
short maxDeger = short.MaxValue;
Console.WriteLine("\nshort veri tipinin max ve min value ispatı");
Console.WriteLine($"Min değer: {mindDeger}");
Console.WriteLine($"Max değer: {maxDeger}");

// \n ile bir alt satıra atlama
Console.WriteLine("\ntek satırda iki değeri ekranda gösterme");
Console.WriteLine($"Min değer: {mindDeger}\nMax değer: {maxDeger}"); //tek satırda iki değeri ekranda gösterme

//short veri tipi ile işlem yapma
Console.WriteLine("\nshort veri tipi ile işlem yapma");
short ogrenciSayisi = 15;
Console.WriteLine("Öğrenci Sayısı: " + ogrenciSayisi);

// öğrenci sayısısa yeni öğrenci ekleme
short yeniOgrenciSayisi = (short)(ogrenciSayisi + 5);
Console.WriteLine("Yeni Öğrenci Sayısı: " + yeniOgrenciSayisi);