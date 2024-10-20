using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Bir yapının metot olduğunu belirtmek için sonuna parantez konur.()

            // Geriye değer döndürmeyen metotlar "void" ile tanımlanır.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Merve Yıldız");
            //    Console.WriteLine("Ada Akbulut");
            //}

            //CustomerList();
            //// Metotlar belli işlemleri tekrardan kullanmak için önemli bir yer ve yapıya sahip

            //void Sum()
            //{
            //    int x = 1; int y = 2; int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();



            #endregion

            #region Geriye değer döndürmeyen String parametreli metodlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Mehmet Yıldız");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe Gül", "Kaya");

            #endregion

            #region Geriye değer döndürmeyen Int parametreli metodlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(8, 7, 6);

            #endregion

            #region Geriye değer döndüren metodlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName(); // Çıktı olarak ekranda bir şey çıkmaz. Çünkü yazdırmadık 

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent:  " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Ülke başkentini giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine(); 

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));


            #endregion

            #region Geriye değer döndüren int parametreli metodlar

            //int Sum(int number1 , int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(54, 98));
            //Console.WriteLine(Sum(12, 68));
            //Console.WriteLine(Sum(25, 40));
            //Console.WriteLine(Sum(10, 30));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci dersi geçti :)" + " Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci dersi geçemedi :( " + " Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 20, 52, 93));
            Console.WriteLine(ExamResult("Ayşe", 20, 52, 20));
            #endregion

            Console.Read();
        }
    }
}
