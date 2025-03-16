// ----------------long data type --------------------
// long veri tipi c# dilinde 64-bit(8 byte) işaretli tam sayı veri tipidir.
// çok büyük tam sayıları tutabilir. örneğin tc kimlik tanımlaması int kullanılmaz çünkü int 10 basamağa değer tutabilir. bundan dolayı tc gibi büyük sayılar için long veri tipi kullanılabilir.
// değer aralığı -9223372036854775808 ile 9223372036854775807 arasında değer tutar. long veri tipi signed(işaretli) veri tipidir.
// sistemlerde ya da veritabanlarında çok büyük sayıları saklmamamıza olanak tanır.
// long alternatifi olarak ulong veri tipini kullanabiliriz. ulong => imzasız long veri tipi. 0 ile 9223372036854775807 arasında değer tutar.

long maxValue = long.MaxValue;
long minValue = long.MinValue;
Console.WriteLine($"long data type min value: {minValue}\nlong data type max value: {maxValue}");

//long veri tipindeki bir sayıyı eğer int veri tipine dönüştürürsek veri kaybı yaşayabiliriz.
long buyukSayi = 1234567890123L;
int kucukSayi = (int)buyukSayi; // bu dönüşüm veri kaybına neden olabilir.
Console.WriteLine(kucukSayi);