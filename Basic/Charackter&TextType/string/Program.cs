// --------------string data type----------
// string veri tipi karakter dizilerini(metinlerini) temsil eder. string veri tipi aslında char dizisinden(array) oluşturulmuş bir türdür.
// bellek boyutu: string veri tipi, her karakter tanımlamada 2 byte(16 bit) kullanır. çünkü c# Unicode karakter sati kullanır.

// string bir değer atandığında değiştirlemez(immutable). bir string değişkeni üzerinde yapılan her bir değişiklik yeni bir string nesnesi oluşturur.

// string'lerin bir length(uzunluk) özelliği vardır.

// string kullanımı
string ad = "Ahmet "; // 0.index=A, 1.index:h
string soyad = "Sayar";
Console.Write(ad + soyad);
Console.WriteLine($"\n{ad} {soyad}");

// ahmet kelimesinin uzunluğunu hesaplama
Console.WriteLine($"ahmet kelimesinin uzunluğu: {ad.Length}");
Console.WriteLine($"soyad kelimesinin uzunluğu: {soyad.Length}");