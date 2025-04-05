// CRM - Customer Relationship Management

using System.Text.Json;

string filePath = "customer.json"; //JSON dosyasının yolu

//Mevcut verileri JSON dosyasından yükle

List<string[]> customers = LoadCustomer();

bool running = true;


while (running)
{
    Console.WriteLine("Customer Relationship Management App");
    Console.WriteLine("1. Müşteri Ekle");
    Console.WriteLine("2. Müşteri Listele");
    Console.WriteLine("3. Müşteri Güncelle");
    Console.WriteLine("4. Müşteri Sil");
    Console.WriteLine("5. Çıkış");

    Console.Write("Seçiminizi yapın(1-5): ");
    string choice = Console.ReadLine(); // Kullanıcıdan bir input alınır.

    switch (choice)
    {
        case "1": // Müşteri ekle
            Console.Write("Müşteri Adı: ");
            string name = Console.ReadLine(); // input

            Console.Write("Müşteri Soyad: ");
            string surName = Console.ReadLine(); // input

            Console.Write("Müşteri Telefonu: ");
            string phone = Console.ReadLine(); // input

            //Müşteri bilgilerini bir dizi olarak ekliyoruz.
            //Kullanıcıdan aldığımız bilgileri customers listesine ekliyoruz.

            customers.Add(new string[]
            {
                name,surName,phone
            });

            SaveCustomers(customers); //Yeni listeyi JSON dosyasına kaydet.
            Console.WriteLine("Müşteri başarıyla eklendi.");
            break;
        case "2": // Müşteri Listele
            if (customers.Count == 0)
            {
                Console.WriteLine("Hiç Müşteri Bulunamadı!");
            }
            else
            {
                Console.WriteLine("Müşteri Listesi");
                for (int i = 0; i < customers.Count; i++)
                {
                    Console.WriteLine($"Ad: {customers[i][0]}, Soyad: {customers[i][1]}, Telefon: {customers[i][2]}");
                }
            }
            break;
        case "3": // Müşteri Güncelle
            Console.Write("Güncellemek istediğiniz müşterinin adını giriniz: ");
            string updateName = Console.ReadLine();

            // İlgili müşteriyi bul
            var customerToUpdate = customers.FirstOrDefault(c => c[0].Equals(updateName, StringComparison.OrdinalIgnoreCase));

            if (customerToUpdate != null)
            {
                Console.WriteLine("Yeni adı girin (mevcut: " + customerToUpdate[0] + "): ");
                string newName = Console.ReadLine();
                Console.WriteLine("Yeni soyadı girin (mevcut: " + customerToUpdate[1] + "): ");
                string newSurname = Console.ReadLine();
                Console.WriteLine("Yeni telefon girin (mevcut: " + customerToUpdate[2] + "): ");
                string newPhone = Console.ReadLine();

                // Boş bırakılan alanlar değiştirilmeyecek
                if (!string.IsNullOrWhiteSpace(newName)) customerToUpdate[0] = newName;
                if (!string.IsNullOrWhiteSpace(newSurname)) customerToUpdate[1] = newSurname;
                if (!string.IsNullOrWhiteSpace(newPhone)) customerToUpdate[2] = newPhone;

                SaveCustomers(customers);
                Console.WriteLine("Müşteri bilgileri güncellendi.");
            }
            else
            {
                Console.WriteLine($"{updateName} adlı müşteri bulunamadı.");
            }
            break;
        case "4": //Müşteri silme
            Console.WriteLine("Silmek istediğiniz müşterinin adını giriniz:");
            string deleteCustomerName = Console.ReadLine();
            int deleteIndex = customers.FindIndex(c => c[0].Equals(deleteCustomerName, StringComparison.OrdinalIgnoreCase));
            if (deleteIndex != -1)
            {
                customers.RemoveAt(deleteIndex);
                SaveCustomers(customers);
                Console.WriteLine("Müşteri başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Müşteri bulunamadı.");
            }
            Console.ReadLine(); 
            break;
        case "5":
            running = false;
            Console.WriteLine("Çıkış Yapılıyor...");
            break;

    }
    Console.ReadLine() ;
    Console.Clear();

}
//Mevcut verileri JSON dosyasından yükleyen metot.
void SaveCustomers(List<string[]> customers)
{
    var customersList = new List<List<string>>();
    foreach (var customer in customers)
    {
        customersList.Add(new List<String>(customer));
    }
    string jsonstring = JsonSerializer.Serialize(customersList);
    File.WriteAllText(filePath, jsonstring, new System.Text.UTF8Encoding(true));

}
List<string[]> LoadCustomer()
{
    if (File.Exists(filePath))
    {
        string jsonString = File.ReadAllText(filePath);
        var customersList = JsonSerializer.Deserialize<List<List<string>>>(jsonString);
        List<string[]> customers = new List<string[]>();
        //Listeyi formatımıza uygun şekilde dönüştürebiliriz.
        if (customersList != null)
        {
            foreach (var customer in customersList)
            {
                customers.Add(customer.ToArray());
            }
        }
        return customers;
    }
    return new List<string[]>();//Dosya yoksa boş bir liste döndürür.
}
