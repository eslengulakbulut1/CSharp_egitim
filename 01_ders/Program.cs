using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1 - Çorbalar");
            Console.WriteLine("2 - Ana Yemekler");
            Console.WriteLine("3 - Soğuk Başlangıçlar");
            Console.WriteLine("4 - Salatalar");
            Console.WriteLine("5 - Tatlılar");
            Console.WriteLine("6 - İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine("----------------------------------");


            #endregion

            #region String Değişkenler


            // string değişkenler
            // değişken_türü değişken_adi;

            //string name;
            //name = "Eslen";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Yılmaz";
            customerPhone = "+90 555 555 55 55";
            customerEmail = "deneme@deneme.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + " / " + city);
            Console.WriteLine("-----------------------------");

            Console.WriteLine();

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 555 555 11 11";
            customerEmail = "test@deneme.com";
            district = "Atakum";
            city = "Samsun";


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + " / " + city);
            Console.WriteLine("-----------------------------");

            #endregion

            #region Int Değişkenler

            // int 
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 350;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("----------------------------------");

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Hesap Tutarı *****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;



            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " Tl");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " Tl");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " Tl");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " Tl");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " Tl");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " Tl");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");

            int totalPrice = totalHamburgerPrice + totalFriesPrice + totalCokePrice + totalWaterPrice + totalLemonadePrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            Console.WriteLine("----------------------------------");



            #endregion

            Console.Read(); // start (başlat) düğmesine bastığında ekranın gelip geri gitmesinin önüne geçmek için yapılır
        }
    }
}
