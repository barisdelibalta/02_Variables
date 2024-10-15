using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)

        {


            #region Double Değişkenler
            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.Read();

            Console.WriteLine("**** Fiyat Listesi ****");
            Console.WriteLine();


            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;
            Console.WriteLine("---- Elma Birin Fiyatı: " + applePrice + "TL");
            Console.WriteLine("---- Portakal Birin Fiyatı: " + orangePrice + "TL");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            Console.WriteLine("-----Patates Birim Fiyatı: " + potatoPrice + "TL");
            Console.WriteLine("-----Domates Birim Fiyatı: " + tomatoPrice + "TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;


            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " TL - Gramaj: " + appleGram + " kg - Toplam Tutar: " + appleTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " TL - Gramaj: " + orangeGram + " kg - Toplam Tutar: " + orangeTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + " TL - Gramaj: " + strawberryGram + " kg - Toplam Tutar: " + strawberryTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " TL - Gramaj: " + potatoGram + " kg - Toplam Tutar: " + potatoTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " TL - Gramaj: " + tomatoGram + " kg - Toplam Tutar: " + tomatoTotalPrice + " TL");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");



            #endregion

            #region Char Değişkenler
            //ABCDEFGHDEF...

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            Console.Read();

            #endregion



            #region Klavye Veri Girişleri
            Console.WriteLine("**Csharp Hava Yolları Yolcu Bilgisi***");
            Console.WriteLine();
            string passengerName;
            string passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();



            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "Yolcu Ad Soyad: " + " " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            ABC12D

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız sandalye Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız televizyon Sayısını Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);



            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.WriteLine("Lütfen 1. Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 3. Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine()); ;

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalaması: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion 

            Console.Read();






















        }
    }
}
