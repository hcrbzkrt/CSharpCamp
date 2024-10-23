using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü
            //ornek1 
            //int i;

            //for ( i = 1 ; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}


            //ornek2

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //ornek3

            //for (int i = 0; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //ornek4

            //Console.Write("ekrana yazılması gereken sayı adedini giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın CUMHURİYET!");
            //}

            #endregion

            #region For Dongüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //ornek2

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);


            //ornek3

            //int totalValue = 0;

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalValue);




            ////ornek4
            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(count);


            //ornek5

            //int bacterium = 1;

            //for (int i = 1; i < 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat sonunda: " + bacterium + " bakteri oluştu.");
            //}



            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i + " merhaba döngü");
            //    i++;
            //}




            //ornek2

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}




            //ornek3

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //} 

            //Console.WriteLine(sum);

            #endregion

            #region Örnek sınav sorusu

            //klavyeden girilen 3 basamaklı sayının basamaklar toplamını hesaplayan kodu yazınız


            int ones, tens, hundreds, sum, number;

            Console.Write("sayıyı giriniz: ");
            number = int.Parse(Console.ReadLine());

            //456
            ones = number % 10;
            hundreds = number / 100;
            tens = (number % 100) / 10;

            sum = ones + tens + hundreds;

            Console.WriteLine("birler basamağı: " + ones);
            Console.WriteLine("onlar basamağı: " + tens);
            Console.WriteLine("yüzler basamağı: " + hundreds);
            Console.WriteLine();
            Console.WriteLine("basamakların toplamı: " + sum);



            #endregion

            Console.Read();

        }
    }
}
