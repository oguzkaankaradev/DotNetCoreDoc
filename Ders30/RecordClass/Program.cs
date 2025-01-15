

//------------------------------------------------------




using RecordClass;
using System.Xml.Linq;




class Program
{
    static void Main()
    {

        ///Record - Kayıt
        ///Veri toplamak için optimize edilmiştir. 
        ///Temel amacı veri depolamaktır.
        ///Verilere kolayca erişilmesini sağlar.
        ///Bu özellekleri sayesinde class ve struct tan farklı olarak özellikler sergilemektedir.
        ///
        ///Record türlerinin özelikleri
        ///Recort türü ToString() methodunu otomatik olarak anlamlı bir şekilde override eder ve nesnenin içeriğini döndürür.



        //class
        Person person = new Person { Name = "Mahsun Karaca", Age = 32};
        Console.WriteLine(person.ToString()); //NamespaceAdı.ClassName - RecordClass.Person

        //record 
        Adam adam = new Adam { Name = "Mahsun Karaca", Age = 32 };
        Console.WriteLine(adam.ToString()); //Adam { Name = Mahsun Karaca, Age = 32 }

        //manuel override
        Insan insan = new Insan { Name = "Mahsun Karaca", Age = 32};
        Console.WriteLine(insan.ToString());//Adam { Name = Mahsun Karaca, Age = 32 }

       
    }
}