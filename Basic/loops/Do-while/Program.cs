// -----------------------do-while---------------------
// C#'da do-while döngüsü en az 1 kez çalıştırılmasını garantileyen bir döngü yapısıdır.
// Koşul döngünün sonunda kontrol edildiği için döngü bloğu en az 1 kez çalıştırılır.
// while döngüsünden farkı do-while önce kod bloğu çalışır sonra şart kontrol edilir.


//      ----------------------do-while yapısı-------------------
//       do
//       {
//          // Koşul kontrol edilmeden burası 1 kez çalıştırılır.
//       }while (True);


// 1. Adım : Kullanıcıdan pozitif bir tam sayı girmesini iste. 
// 2.Kullanıcı negatif bir sayı girene kadar döngü devam etsin.


int sayi;
do
{
    Console.Write("Pozitif bir tam sayı girin (Negatif Sayı Girince Döngü Biter): ");
    sayi = Convert.ToInt32(Console.ReadLine());

} 
while (sayi >=0);  // Eğer girilen sayı negatif değilse döngü devam eder.


