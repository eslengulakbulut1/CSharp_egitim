using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            double number;

            number = 4.85;

            Console.WriteLine(number);

            Console.WriteLine("***** Fiyat listesi*****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.22;
            orangePrice = 20.57;
            strawberryPrice = 65.88;
            potatoPrice = 9.74;
            tomatoPrice = 6.85;

            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("---- Portakal Birim fiyatı: " + orangePrice + " TL");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");


            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 1.486;
            strawberryGram = 0.750;
            potatoGram = 4.258;
            tomatoGram = 2.145;

            Console.WriteLine("---------------------------------------------");

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan ürün: Elma -" + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan ürün: Portakal -" + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan ürün: Çilek -" + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan ürün: Patates -" + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan ürün: Domates -" + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("ALışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler
            //ABCDEFGH
            //DEF....TOPLANTI SAAT 20:00'DE
            // " '

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion

            #region Klavyeden veri girişleri string

            Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, costumerID;

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

            Console.Write("Yolcu TC: ");
            costumerID = Console.ReadLine();



            Console.WriteLine();
            Console.WriteLine("------------------");

            Console.WriteLine("Yolcu TC No: " + costumerID + " - Yolcu Adı: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve dönüşümler

            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 15000;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoeCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden ondalıklı sayı işlemleri
            double exam1, exam2, exam3, result;

            Console.Write("1. Sınav Notu: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("2. Sınav Notu: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("3. Sınav Notu: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.ReadLine();

        }
    }
}
