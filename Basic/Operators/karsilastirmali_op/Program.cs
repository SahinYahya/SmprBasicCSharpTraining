// C#'  ta karşılaştırmalı op.ler, iki değeri karşılaştırmak için kullanılır ve genellikle bool(true/false) sonuç döndürür.

//1.Eşittir(==) op: İki değerin eşit olup olmadığını kontrol eder.
int a = 5, b = 6;
Console.WriteLine(a == b); // false

// 2.Eşit değil(!=) op: İki değerin farklı olup olmadığını kontrol eder.
int x = 5, y = 10;
Console.WriteLine(x != y); //Çıktı: true

// 3.Büyüktür(>) ve Küçüktür(<) op: Bir değerin diğerinden büyük olup olmadığını kontrol eder.
Console.WriteLine(y > x); //Çıktı:True
Console.WriteLine(y < x); //Çıktı:False

// 4.Büyük eşit(>=) ve Küçük eşit(<=): Bir değerin diğerinden büyük veya büyük eşit, küçük veya küçük eşit olup olmadığını kontrol ederler.
int s1 = 5, s2 = 10;
Console.WriteLine(s1 >= s2); //Çıktı: False
int s3 = 3, s4 = 4;
Console.WriteLine(s3 <= s4); //Çıktı: True