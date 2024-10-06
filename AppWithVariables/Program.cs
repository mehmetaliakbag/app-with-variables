Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz.");

#region Questions
Console.Write("T.C. Kimlik Numarası: ");
string noTc = Console.ReadLine();

Console.Write("Ad: ");
string name = Console.ReadLine();

Console.Write("Soyad: ");
string surname = Console.ReadLine();

//Telefon numarası üzerinde aritmatik işlem yapılacak bir değer değildir, isim gibi statiktir.
//Bunun için string tipi kullandım
Console.Write("Telefon Numarası: ");
string noPhone = Console.ReadLine();

Console.Write("Yaş: ");
string age = Console.ReadLine();

Console.Write("İlk Aldığı Ürünün Fiyatı: ");
double price1 = Convert.ToDouble(Console.ReadLine());

//Ürün fiyatı üzerinde aritmatik işlem yapmaya müsaittir ve ürün fiyatları değişebilir, dinamiktir.
//Bunun için sayısal bir tip ollan double tipini kullandım
Console.Write("Son Aldığı Ürünün Fiyatı: ");
double price2 = double.Parse(Console.ReadLine());

double total = price1 + price2;

double result = total / 10;

#endregion

Console.WriteLine("--------------------------------------------");

Console.WriteLine($"{noTc} T.C. kimlik numaralı {name} {surname} isimli kişi için kayıt oluşturulmuştur." +
                  $"\n{noPhone} telefon numarasına bildirim mesajı gönderilmiştir." +
                  $"\n{total} toplam harcama karşılığı kazanılan %10 Patika Puan miktarı -> {result} TL'dir.");


Console.ReadKey();