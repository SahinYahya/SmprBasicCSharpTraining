// -----------------byte data type-----------------

// byte data type 0 ile 255 arasında değer alır. 8 bitlik tam sayı değeri tutar.

// byte data type max value
byte maxValue = 255;
Console.WriteLine("byte veri tipinin max değeri: " + maxValue);
byte minValue = 0;
Console.WriteLine("byte veri tipinin min değeri: " + minValue);

// byte data type değerlernin max ve min ispatı
byte byteMaxValue = byte.MaxValue;
Console.WriteLine("byte max value ispatı: " + byteMaxValue);

byte byteMinValue = byte.MinValue;
Console.WriteLine("byte min value ispatı: " + byteMinValue);

// byte değişkenine 255 ten büyük ve 0 dan küçük değer atama yapılırsa hata alırız.
//byte byteValue = 256; //Hatalı kullanım
//byte byteValue2 = -1; //Hatalı kullanım