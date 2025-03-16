// ---------------char data type--------------

// char veri tipi tek bir karakteri temsil eder: Örnek: 'A'
// char, 16-bit(2 byte) yer kaplar ve bir karakteri temsil etmek için 2 byte'lık bir bellek kullanır.

// char veri tiplerinin Unicode değerleri vardır.
// Karakterlerin Unicode değerleri
Console.WriteLine((int)'A'); // 65
Console.WriteLine((int)'S');

// Karakterlerin ikili sistemde (binary) gösterimi
Console.WriteLine(Convert.ToString('A', 2)); // 1000001
Console.WriteLine(Convert.ToString('B', 2)); // 1000010