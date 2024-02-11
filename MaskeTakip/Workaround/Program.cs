// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using Entities.Concrete;

SelamVer("Nazife");
SelamVer("Ahmet");
SelamVer("Ali");
SelamVer();

int sonuc = Topla(6,58);

//Diziler // Arrays

string[] ogrenciler = new string[3]; //diziler 0dan başlar
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";
// ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" }; // burdaki array yerine generic yapıları kullanıyoruz artık
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

Person person1 = new Person();
person1.FirstName = "ENGİN";
person1.LastName = "DEMİROĞ";
person1.DateOfBirthYear = 1985;
person1.NationalId = 123;

Person person2 = new Person();
person2.FirstName = "Murat";

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
    
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1 ", "İzmir 1 " }; // burada referans tipin referans probleminden kurtuluyorum
yeniSehirler1.Add("Adana 1");
foreach (var s in yeniSehirler1)
    
{
    Console.WriteLine(s);
}

static void SelamVer(string isim="isimsiz") // void programlamada emir kipi gibi çalışır. Güncelle Ekle gibi. 
{
    Console.WriteLine("Merhaba" + isim);
} //METOT


static int Topla(int sayi1 = 5 , int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam:" + sonuc);
    return sonuc;
   
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


