// See https://aka.ms/new-console-template for more information
//Namespace sayesinde biz yazdığımız kodu başka satfalarda kullanıyoruz.
//using ile kullanacağımız namespaceyi 
using Introduction;
using payment;

Console.WriteLine("Hello, World!");

//bu alan siparişler alanı
Order order = new Order();
order.Name = "BAKLAVA";

//Bu alan Ödeme alanı

GarantiBankKartBilgileri garantiBankKartBilgileri = new GarantiBankKartBilgileri();
