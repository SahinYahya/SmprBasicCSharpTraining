// kullanıcıdan değer alma

//1-Kullanıcıdan iki sayı girmesini iste.
//2-kullanıcıdan alınan değerleri topla, çarp, böl ve bu iki sayının ortalamasını al

//NOT: Kullanıcıdan alacağımız değer ilk seferde string olarak alınır sonrasında bunu istediğimiz veri tipine dönüştürebiliriz.
//aşağıdaki örnekte string olan bir değeri int yani  int tam sayı veri tipine dönüştürmemiz gerekir. çünkü kullanıcıdan alacağımız sayı tam sayı tipinde olması gerekir.
//Console.Write("1.Sayıyı Gir: ");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.Write("2.Sayıyı Gir: ");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//int topla = sayi1 + sayi2;
//int carp = sayi1 * sayi2;
//int bol = sayi1 / sayi2;
//int ortalama = topla / 2;
//Console.WriteLine("Toplama: " + topla);
//Console.WriteLine("Çarpma: " + carp);
//Console.WriteLine("Bölme: " + bol);
//Console.WriteLine("Ortalama: " + ortalama);

// mod alma: bir sayının kalanını bulma. burada genellikle bir listede kaç tane sayının çift ya da kaç tane sayının tek olduğunu ekrana yazdırabiliriz.
int x = 15;
int modAlma = x % 2;
Console.WriteLine(modAlma);