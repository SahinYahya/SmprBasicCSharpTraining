// ----------------sbyte data type-----------------
// sbyte data type -128 ile 127 arasında değer alır. yani işaretli(eksi ve artı yönlü olması.) 8 bitlik tam sayı değeri tutar. 8 bit = 1 byte

sbyte sbyteMaxValue = 127;
Console.WriteLine("sbyte veri tipinin max değeri: " + sbyteMaxValue);
sbyte sbyteMinValue = -128;
Console.WriteLine("sbyte veri tipinin min değeri: " + sbyteMinValue);

// sbyte data type değerlernin max ve min ispatı
sbyte sbyteMaxValue2 = sbyte.MaxValue;
Console.WriteLine("sbyte max value ispatı: " + sbyteMaxValue2);
sbyte sbyteMinValue2 = sbyte.MinValue;
Console.WriteLine("sbyte min value ispatı: " + sbyteMinValue2);

sbyte havaSicakligi = 2;
//int havaSicakligi2 = 10;
Console.WriteLine("Hava sıcaklığı: " + (sbyte)(havaSicakligi + 10));