// Mantıksal operatörler: boolean(true/false) ifadelerle işlem yapmaya yarar. Genellikle koşul ifadelerinde (if,while,for) kullanılır.

// 1.Ve(&&) op: Her iki koşul eğer true ise sonuç true olur. en az bir koşul false ise durum false olur.
//true    true  = true
bool sonuc = (5 > 3) && (5 > 2);
Console.WriteLine(sonuc); //Çıktı : True

//false      true  = false
bool sonuc2 = (5 > 10) && (5 > 2);
Console.WriteLine(sonuc2);

// 2.Veya( || ) op: Her iki koşul eğer true ise sonuç true olur. en az bir koşul false ise durum yine true olur. her ikisi de false ise o zaman sonuç false olur.
//true       true  =  true
bool result = (15 > 10) || (50 > 20);
Console.WriteLine(result);
//false       true  =  true
bool result2 = (15 > 25) || (22 > 12);
Console.WriteLine(result2);

// Değil(!) op: önüne geldiği her şeyi tersine çevirir.
// true olanı false, false olanı true yapar.

bool durum = true;
Console.WriteLine("true durum1: " + durum); //Çıktı: true
Console.WriteLine("true durum2: " + !durum); //Çıktı: false

// bool a = (5>3);  a ifedesini false yapalım.
bool a = (5 > 3); //true
Console.WriteLine(!a); //Çıktı: false