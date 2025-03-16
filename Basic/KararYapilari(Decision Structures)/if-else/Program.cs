// ----------------------if-else----------------------

// bir koşuln true veya false olmasına bağlı olarak farklı kod bloklarının çalıştırılmasını sağlar.
// if-else yapısı bir koşulun doğru olup olmadığını kontrol eder ve doğru ise belirtilen kod bloğunu çalıştırır.



/*  ----------------------if-else genel yapısı----------------------

    if (koşul) // if : eğer anlamına gelir.
    {
        // koşul doğruysa çalışacak kod bloğu
    }
    else // else : aksi halde anlamına gelir.
    {
        // koşul yanlışsa çalışacak kod bloğu
    }
*/

using System.Linq.Expressions;

int not = 70;
if (not >= 50)
{
    Console.WriteLine("Öğrenci geçti");
}
else
{
    Console.WriteLine("Öğrenci kaldı");
}

// Bir sayının tek veya çift oldugunu 2 farklı yöntemle ekrana yazdıralım

// 1. Yöntem
int a = 18;
if (a % 2 == 0)
{
    Console.WriteLine("Sayı çifttir");
}
else
{
    Console.WriteLine("Sayı tektir");
}


// 2. Yöntem
// Terary (Koşullu) Op. : if-else yerine tek bir satırda koşullu arama yapmamızı sağlar.

int sayi = 20;
string sonuc = (sayi % 2 == 0) ? "Sayı çift" : "Sayı tek";
Console.WriteLine("Sayı: " + sonuc);

// Kullanıcıdan yaş ve maaş bilgisi alarak aşağıdaki kurallara göre uygunluğunu kontrol eden programı yazınız.

// K1. yaşı 18 ile 65 arasında olmalıdır.
// K2. maaşı en az 25000 olmalıdır.
// K3. Eğer her iki koşul sağlanıyorsa "Uygun" yazsın.
// K4. Eğer her iki koşuldan biri sağlanmıyorsa "Uygun Değil" yazsın.


// Kullanıcıdan yaş ve maaş bilgisi alma

Console.Write("Yaşınız: ");
int yas = Convert.ToInt32(Console.ReadLine());

Console.Write("Maaşınız: ");
int maas = Convert.ToInt32(Console.ReadLine());

if (yas >= 18 && yas <= 65 && maas >= 25000)
{
    Console.WriteLine("Uygun");
}
else
{
    Console.WriteLine("Uygun Değil");
}



