// CRM - Customer Relationship Management

using System;
using System.Runtime.Loader;

string filePath = "customer.json"; //JSON dosyasının yolu

//Mevcut verileri JSON dosyasından yükle

List<string[]> customers = LoadCustomer();

bool running = true;


while (running)
{
    Console.Write("Customer Relationship Management App");
    Console.Write("1. Müşteri Ekle");
    Console.Write("2. Müşteri Sil");
    Console.Write("3. Müşteri Güncelle");
    Console.Write("4. Müşterileri Listele");
    Console.Write("5. Çıkış");

    Console.Write("Seçiminizi yapın: ");
    string choice = Console.ReadLine(); // Kullanıcıdan bir input alınır.

    switch (choice)
    {
        case 1: // Müşteri ekle
            Console.Write("Müşteri Adı: ");
            string name = Console.ReadLine(); // input
            Console.Write("Müşteri E-Posta: ");
            string email = Console.ReadLine(); // input
            Console.Write("Müşteri Telefonu: ");
            string phone = Console.ReadLine(); // input

            //Müşteri bilgilerini bir dizi olarak ekliyoruz.
            //Kullanıcıdan aldığımız bilgileri customers listesine ekliyoruz.

            customers.Add(new string[]
            {
                name,email,phone
            });
         

            break;

    }






//Mevcut verileri JSON dosyasından yükleyen metot.
static List<string[]> LoadCustomer()
{

}