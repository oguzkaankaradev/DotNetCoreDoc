// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

///veri tipleri
///byte 8 bit değer tutar. 0,255 arası pozitif değerler
///veri tipleri var ile başlamaktadır. Variablenin var ından alınmaktadır. 
///ek olarak sbyte, short, ushort, uint
///int tam sayıları tutan veri tipidir.
///long, ulong ; int den büyük veriler için kullan.
///
///string düz yazı veri tipidir.
///
///floal 32 bittir, 7 basamaklı hassas değerler alır. 
///double 64 bittir, 15-16 değer hafıza tutar. 
///decimal 128 bittir 28-29  basamak hassas değer tutar.
///
///bool true yada false
///
///char Tek bir harf tutar.
///Enum : kullanıcı tarafından tanımlanan sabit değerler listesidir.

byte kitapSayısı = 255;
int age = 18;//buradaki age bir değişkendir
string name = "musab";
double oyunPuani = 4.34;
bool levelStatus = true;
//float Kontrol edilecek. 
char Unicode = 'A';


double deger1 = 256.4567;
double deger2 = 732.8940;
double toplam;

toplam = deger1 / deger2 * 123456789;

Console.WriteLine(toplam);



//enum UserRole
//{
//    Admin = 0,
//    Moderatör = 1,
//    User = 2,
//    Guest = 3
//}