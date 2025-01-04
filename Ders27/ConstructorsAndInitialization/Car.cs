using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInitialization
{
    internal class Car
    {
        //brand ve sınıfın alanları(fiesldları) ve biz bu alanlarda veriler tutarız.
        public string Brand;
        public string Speed;

        ///classın fildlerının ve propertieslerinin başlangıç değeri olması gerkmektedir.
        ///c# bunun birkaç yolu vardır. 
        ///----
        ///a. varsayılan değer
        ///sayısal türlerde(int, doule...) başlangıç değeri 0 dır.
        ///referans türlerde(string, object...) sayısal değer null.
        ///boolean da sayısal değer false dir.
        ///---
        ///Eğer bir fied veya bir properties için farklı bir değer gerekli ise, varsayılan değerden farklı bir değer ile başlatılması gerekmektedir.
        ///başlangıç değerini değiştirmek için birkaç yöntem vardır.
        ///---

        #region fied Initializers(alan başlatıcılar)
        ///Fieldlara başlangıç değeri atar.
        ///Fieldlara başlangıö değeri aşağıdaki gibi atanır.

        private string Model = "Togg T10X";
        #endregion

        #region Constructors (yapıcılar)
        ///bir Classı oluştururken field veya properties başlatmanın en yaygın yolu Constructors kullanmaktır
        ///Classın bir nesnesi oluştuğunda çalışan methodtur.
        ///Nesnenin başlangıç durumunda ayarlamalar yapmak için kullanılır.
        ///Otomatik olarak çalışır. amaç nesnenin başlatılmasını sağlamak.
        ///Classların başlangıç değerine aşağıdaki gibi müdahale edilir.

        public Car(string brand, string speed)
        {
            Brand = brand;
            Speed = speed;
        }


        //Car car = new Car("BMV", "230"); //bunu program cs te yaz.



        #region Defferent EXAMPLE

        //Field initialize edildi.
        public string NumberOfDor = "15";
        public string Color = "Black";

        //class default değerlerle başladı.
        public Car() { }
        #endregion

        #region Ensuring the Setting of Mandatory Fields:

        //Zorunlu alanların ayarlanmasını sağlamak

        public string GasSituation;

        public Car(string gasSituation)
        {
            if (string.IsNullOrEmpty(gasSituation))
            {
                throw new ArgumentException("Benzin durumu boş olamaz. Sen beni yoldamı bırakacan.");
            }

            GasSituation = gasSituation;
        }

        #endregion


        #endregion


    }
}
