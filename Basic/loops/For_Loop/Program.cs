// C#'ta döngüler programı çalıştırdığımızda birden fazla olan komutları tek tek yazmak yerine döngü kavramlarını kullanarak daha kısa ve daha az kod yazarak yapmamızı sağlar.

/*
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);
*/

// NOT : Yukarıdaki örnekte olduğu gibi tek tek yazmak hem yorucu hem zaman kaybı hem de maliyetlidir.
// Bu işlemi for dngüsü kullanarak aynı çıktıyı alabiliriz. For döngüsü kendini tekrar etme prensibine örnek olabilir.

//---------------------------------For Döngüsü(for loop)---------------------------------


//      for   (değer ; şart; artırma veya azaltma)
//      for(int i =1; i<=5; i++ veya i--)
//      {
//      // Döngü içerisinde çalıştırılacak kodlar. Bu kod bloğu şart sağlandığı sürece çalışır.
//      }

//for döbgüsü belirli bir başlangıç, koşul ve arttırma ya da azaltma ifadesi içeren, belirli bri sayıda tekrarlanan bir döngüdür.
//döngü içerisindeki kod bloğu şart sağlandığı sürece çalışır.


/*
 * 
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
*/


// 1den yüze kadar olan sayıların toplamını bulan programı yazınız.

/*
int toplam = 0;
for (int i = 1; i <= 100; i++)
{
    toplam += i;
}
Console.WriteLine("Toplam: " + toplam);

*/


// 1den yüze kadar olan çift sayıların toplamını veren konsol appi yazın.

/*
int toplam = 0;
for(int i = 1; i <= 100; i++)
{
    toplam += i ;
}

Console.WriteLine("Toplam: " + toplam);
*/

/* 1. yöntem
 
 
int toplam = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0) // Eğer i çift sayı ise bunu toplam değişkenine ata
    {
        toplam += i; //Çift sayıları topla
    }
}
Console.WriteLine("1den 100e Kadar Olan Çift Sayıların Toplamı: " + toplam);

*/

/* 2. Yöntem
 
 
int toplam = 0;
for(int i = 2; i <= 100; i+=2) // eğer i çift sayı ise bunu toplam değişkenine ata
{
    toplam += i ; // Çift sayıları topla
}

Console.WriteLine("1den 100e Kadar Olan Çift Sayıların Toplamı: " + toplam);

*/


