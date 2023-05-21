// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random rnd = new Random();
for  (int i = 1; i<=5; i++)
{
    int sayi = rnd.Next(10, 25);
    Console.WriteLine(sayi.ToString());
}
int toplam = 0;
for (int i=1; i<5; i++)
{
    int sayi = rnd.Next(30, 45);
    toplam=toplam+sayi;

}
Console.WriteLine("Sayıların Toplamı="+toplam.ToString());
Random ondalikli_sayi=new Random();
Random tam_sayi = new Random();
double toplam1 = 0;
for (int i = 1; i<= 5; i++)
    {

    int tam = tam_sayi.Next(0,4);
    double ondalikli = ondalikli_sayi.NextDouble();
    double sonuc = tam + ondalikli;
    toplam1=toplam1 + sonuc;
    Console.WriteLine(sonuc);

}
Console.WriteLine("Sayıların toplamı="+toplam1.ToString());

string isimler = "Kadir-Burak-Hilal-Yağmur-Fırat";
string[] parcalar = isimler.Split('_');
for (int i = 0; i < parcalar.Length; i++) ;
{
    Console.WriteLine(parcalar[i].ToString());
}
string isim = "KADİR";
char[] harfler = isim.ToCharArray();
for (int i = 0; i < harfler.Length; i++)
    string isimler = "Kadir-Burak-Hilal-Yağmur-Fırat";
string[] parcalar = isimler.Split('_');
for (int i = 0; i < pacalar.Length; i++)
{
    Console.WriteLine(harfler[i]);
}
string ders_adi = "İnternet ve Programlama";
string son_kelime = ders_adi.Insert(11, "Web");
Console.WriteLine(son_kelime);
ders_adi = "İnternet ve Web Web Programlama";
son_kelime = ders_adi.Remove(16, 4);
Console.WriteLine(son_kelime);
isim = "KadiR";
son_kelime=isim.ToUpper();
Console.WriteLine(son_kelime);

isim = "KadiR";
son_kelime = isim.ToLower();
Console.WriteLine(son_kelime);
burda kaldım
bool sayimi = false;
while 
Console.WriteLine("Bir sayı giriniz");
string veri =Console.ReadLine();
if (String.IsNullOrWhiteSpace(veri) ==true)
{
    Console.WriteLine("Veri giriniz");
    int sayi;
    if (int.TryParse("Sayı girdiniz");
}

{
}