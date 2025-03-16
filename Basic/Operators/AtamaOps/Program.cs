// ATAMA OPS.(Assignment Operators) 

// C#'ta atama operatörleri , bire değişkene değer atamak veya değişkenin değerini güncellemek için kullanılır. 

// TEMEL ATAMA OP.: (=) Bir değişkene doğrudan bir değer atamak için kullanılır.

// 1.Tam sayı tipinde a adında bir değişken tanımla.

// 2. a'ya 5 değerini ata.  

// 3. ekrana yazdırmadan önce a değerini 3 artıralım.

// 4. a'yı artırdıktan sınra son halini ekrana yazdıralım.


// 1. Yöntem    
int a = 5;   
a = a + 3;  
Console.WriteLine($"a'yı 3 artırdıktan sonra : {a}");  //Çıktı : 8  

// 2. Yöntem    
a += 4; // a = a + 4 ile aynı işlemi yapar.

Console.WriteLine($"a'yı 3 artırdıktan sonra : {a}");

// Eksiltme(-=) op.: Bir değişkenin değerinden bir sayıyı çıkarmak için kullanılır.
int b = 5;
b -= 3; // b = b + 3 ile aynı işlemi yapar.

//3.Çarpma(*=) op.: Bir değişkenin değerini bir sayı ile çarpmak için kullanılır.
int c = 5;
c *= 3; // c = c * 3 ile aynı işlemi yapar.

// 4. Bölme(/=) op.: Bir değişkenin değerini bir sayıya bölmek için kullanılır.
int d = 5;
d /= 3; // d = d / 3 ile aynı işlemi yapar.

// 5. Mod alma(%=) op.: Bir değişkenin değerini bir sayıya böldüğünde kalanı bulmak için kullanılır.    
int x = 5;
x %= 3; // x = x % 3 ile aynı işlemi yapar.



// Basla
// Tam sayı türünde "a" adında bir değişken tanımla
// "a" değişkenine 5 değerini ata
// "a" değişkeninin değerini 3 artır
// "a" değişkeninin son halini ekrana yazdır
// Bitir



int y = 5;
y += 3;
Console.WriteLine($"y değişkeninin son hali : {y}");

