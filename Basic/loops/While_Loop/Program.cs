// Koşul sağlandığı sürece kod bloğu tekrar tekrar çalışır. 


/*
while (true) // Kullanıcı çıkmak isteyene kadar döngü devam eder
{
    Console.Write("Notunuzu girin: ");
    int not1 = Convert.ToInt32(Console.ReadLine());

    // Eğer kullanıcı çıkmak isterse (-1 girerse) döngüden çık
    if (not1 > 100 || not1 < 0)

        Console.WriteLine("Geçersiz bir değer girdiniz: ");


    // Not aralığını kontrol et
    else if (not1 >= 90 || not1 == 100)
    {
        Console.WriteLine("Harf Notunuz: AA");
    }
    else if (not1 >= 80)
    {
        Console.WriteLine("Harf Notunuz: BA");
    }
    else if (not1 >= 70)
    {
        Console.WriteLine("Harf Notunuz: BB");
    }
    else if (not1 >= 60)
    {
        Console.WriteLine("Harf Notunuz: CB");
    }
    else if (not1 >= 50)
    {
        Console.WriteLine("Harf Notunuz: CC");
    }
    else if (not1 >= 40)
    {
        Console.WriteLine("Harf Notunuz: DD");
    }
    else
    {
        Console.WriteLine("Harf Notunuz: FF");
    }

    Console.WriteLine(); // Boş satır ekleyerek çıktıyı düzenli göster
}

*/


// 1. Sonsuz döngü örneği. Aşağıdaki örnekte döngü sonsuza kadar devam eder.
// Çünkü koşul her durumda sağlanıyor ve koşul sağlandığı için kod bloğu sürekli çalışır. 
// Bu da ram belleği doldurana kadar devam eder.

/*
int adet = 5;
while (adet > 0)
{
    Console.WriteLine("Merhaba Dünya!");
}
*/

int adet = 5;
int sayac = 0;
while (adet > 0)
{
    sayac += 1;
    Console.WriteLine($"{sayac}.adım:Sayı 0'dan büyüktür.");
    adet = adet - 1;
}
