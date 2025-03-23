// Student Managemen Application: CRUD Operations CRUD=> Create, Read, Update, Delete

/*
 --------------------------- Uygulama algoritması ------------------------
  1.Başlangıç:
            1.Adım: Öğrenciler adlı bir liste oluştur
            2.Adım: Devam alanında bir "boolean" değişkeni tanımla ve değerini "true" olarak ata.
  2.Ana döngü(while):
            - Devam değişkeni true olduğu sürece, ana döngü çalışacak. Bu döngüde kullanıcıdan aldığı seçime göre davranacak ve 
              yapılan seçimlere göre ilgili işlemler yapılacak.
  3.Menüyü yazdır:
            1.Öğrenci ekle
            2.Öğrenci sil
            3.Öğrenci güncelle
            4.Öğrencileri listele
            0.Çıkış
4.Kullanıcı Seçimi:
            - Kullanıcıdan bir seçim yapılması istenecek. (input istenecek)
5.Seçime göre işlem yap:
            - Seçilen işlemi kontrol etmek için switch-case yapısını kullan.
            // Case 1: - Öğrenci ekle
            // Case 2: ....
            // Case 3: ....
            // Case 4: ....
            // Case 5: ....
6.Döngü sonrası:
            - Her işlemden sonra kullanıcıya "Devam Etmek İçin Bir Tuşa Basınız" mesajı gösterilsin.
7.Programı sonlandırma:
            - Eğer kullanıcı 0 (sıfır) tuşuna basarsa program sonlansın.
            
  */

/*
// 1. Başlangıç
List<string> ogrenciler = new List<string>();
        bool devam = true;

// 2. Ana döngü
while (devam)

// 3. Menüyü yazdır
{
    Console.Clear();
    Console.WriteLine("==== Öğrenci Yönetim Sistemi ====");
    Console.WriteLine("1. Öğrenci Ekle");
    Console.WriteLine("2. Öğrenci Sil");
    Console.WriteLine("3. Öğrenci Güncelle");
    Console.WriteLine("4. Öğrencileri Listele");
    Console.WriteLine("0. Çıkış");
    Console.Write("Seçiminizi yapın: ");

// 4. Kullanıcı Seçimi
string secim = Console.ReadLine();

// 5. Seçime göre işlem yap
switch (secim)
{
case "1":
Console.Write("Eklenecek öğrencinin adını girin: ");
string yeniOgrenci = Console.ReadLine();
ogrenciler.Add(yeniOgrenci);
Console.WriteLine("✅ Öğrenci eklendi.");
break;

case "2":
Console.WriteLine("Silinecek öğrencinin numarasını girin:");
for (int i = 0; i < ogrenciler.Count; i++)
{
Console.WriteLine($"{i + 1}. {ogrenciler[i]}");
}
Console.Write("Seçim: ");
if (int.TryParse(Console.ReadLine(), out int silIndex) && silIndex >= 1 && silIndex <= ogrenciler.Count)
{
Console.WriteLine($"🗑️ {ogrenciler[silIndex - 1]} silindi.");
ogrenciler.RemoveAt(silIndex - 1);
}
else
{
Console.WriteLine("❌ Geçersiz seçim!");
}
break;

case "3":
Console.WriteLine("Güncellenecek öğrencinin numarasını girin:");
for (int i = 0; i < ogrenciler.Count; i++)
{
Console.WriteLine($"{i + 1}. {ogrenciler[i]}");
}
Console.Write("Seçim: ");
if (int.TryParse(Console.ReadLine(), out int guncelleIndex) && guncelleIndex >= 1 && guncelleIndex <= ogrenciler.Count)
{
Console.Write("Yeni isim: ");
string yeniIsim = Console.ReadLine();
Console.WriteLine($"✏️ {ogrenciler[guncelleIndex - 1]} → {yeniIsim}");
ogrenciler[guncelleIndex - 1] = yeniIsim;
}
else
{
Console.WriteLine("❌ Geçersiz seçim!");
}
break;

case "4":
Console.WriteLine("📋 Öğrenci Listesi:");
if (ogrenciler.Count == 0)
{
Console.WriteLine("⛔ Liste boş.");
}
else
{
for (int i = 0; i < ogrenciler.Count; i++)
{
Console.WriteLine($"{i + 1}. {ogrenciler[i]}");
}
}
break;

case "0":
devam = false;
Console.WriteLine("🚪 Programdan çıkılıyor...");
break;

default:
Console.WriteLine("⚠️ Geçersiz seçim!");
break;
}

// 6. Devam mesajı
if (devam)
{
Console.WriteLine("\nDevam etmek için bir tuşa basınız...");
Console.ReadKey();
}
}

// 7. Program bitti
        Console.WriteLine("Program sonlandı.");
   

*/

// 1. Başlangıç
List<string> students = new List<string>();
bool isTrue = true;

// 2. Ana döngü
while (isTrue)

// 3. Menüyü yazdır
{
    Console.WriteLine("==== Öğrenci Yönetim Sistemi ====");
    Console.WriteLine("1. Öğrenci Ekle");
    Console.WriteLine("2. Öğrenci Sil");
    Console.WriteLine("3. Öğrenci Güncelle");
    Console.WriteLine("4. Öğrencileri Listele");
    Console.WriteLine("5. Çıkış");

    Console.Write("Seçiminizi yapın: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {

        case 1: // Öğrenci ekle
            Console.WriteLine("Eklemek İstediğiniz Öğrencinin Adını Giriniz: ");
            string newStudent = Console.ReadLine(); // input
            students.Add(newStudent);
            Console.WriteLine($"{newStudent} adlı öğrenci başarıyla eklendi.");
            break;

        case 2: // Öğrenci sil
            Console.WriteLine("Silmek İstediğiniz Öğrencinin Adını Giriniz: ");
            string removeSt = Console.ReadLine(); // input
            if (students.Remove(removeSt))
            {
                Console.WriteLine($"{removeSt} adlı öğrenci başarıyla silindi.");
            }
            else
            {
                Console.WriteLine($"{removeSt} adlı öğrenci bulunamadı" );
            }
            break;
        case 3:
            Console.WriteLine("Güncellemek İstediğiniz Öğrencinin Adını Giriniz: ");
            string oldStName = Console.ReadLine();
            if (students.Contains(oldStName))
            {
                Console.WriteLine("Yeni İsmi Giriniz: ");
                string newStName = Console.ReadLine();
                int index = students.IndexOf(oldStName);
                students[index] = newStName;
                Console.WriteLine($"Öğrenci '{oldStName}' adı '{newStName}' olarak güncellendi ");
            }
            else
            {
                Console.WriteLine($"Öğrenci {oldStName} bulunamadı.");
            }
            break;  
        case 4: // Öğrenci listeleme
            Console.WriteLine("\nÖğrenci Listesi: ");
            if (students.Count == 0)
            {
                Console.WriteLine("Listede Öğrenci Yok");
            }
            else
            {
                int counter = 0;
                foreach (var student in students)
                {
                    counter++;
                    Console.WriteLine($"{counter} - {student}");
                }
            }
            break;
        case 5: 
            isTrue = false;
            Console.WriteLine("Çıkış Yapılıyor...");
            break;
        default:
            Console.WriteLine("\nYanlış bir seçim yaptınız! 1-5 arasında değer girin.");
            break;


    }

}

/*
            string updateSt = Console.ReadLine(); // input
            if (students.Remove(updateSt))
            {
                Console.WriteLine($"{updateSt} adlı öğrenci başarıyla silindi.");
            }
            else
            {
                Console.WriteLine($"{updateSt} adlı öğrenci bulunamadı");
            }
            break;

*/