//Şart sağlıyorsa işlem gerçekleşsin - eğer ; kısacası if koşulu sağlıyorsa yapılması gereknler
//şart sağlamıyorsa gerçekleştirsin. - değilse ; koşulu sağlamıyorsa yapılamsı gerekenler
int a = 5;
int b = 3;

if (a + b > 10)//sepet
{
    Console.WriteLine("hediye çeki kazandınız");
}
else
{
    Console.WriteLine("alışverişe devam et.");
}


//ikinci kullanımı 
if (a + b > 10)//sepet
    Console.WriteLine("hediye çeki kazandınız");
else
    Console.WriteLine("alışverişe devam et.");

//