﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            ////Foreach(1;2;3;4)
            ////1:Değişken türü / 2:Değişken adı / 3:In / 4:Liste,Koleksiyon,Dizi
            //string[] cities = { "milano", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = {45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() // Foreach döngüsü sadece dizilerle çalışmaz listelerle de çalışır.
            //{
            //    1,2, 3, 4, 5, 6, 7
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi
            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma

            Console.WriteLine("---------------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            // öğrenci iism ve not ortalamalarını saklayacak diziler

            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine("---------------------------------------------");
                double totalExamResult = 0;

                // her öğrenci için 3 sınav notu
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topla
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExamResult / 3;

            }

            
            // Sınav Ortalamaları 

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAverage[i]}");

                // öğrencilerin geçip kalma durumlar
                if ( studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }

                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("---------------------------------------------");

            }





            #endregion
            Console.Read();
        }
    }
}
