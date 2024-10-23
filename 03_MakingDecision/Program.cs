using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //ornek1
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //ornek2
            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı!");
            //}
            //else {
            //    Console.Write("hatalı bilgi!");
            //}


            //ornek3
            //int number;
            //Console.Write("Sayı giriniz : ");
            //number= int.Parse(Console.ReadLine());

            //if (number == 0) {
            //    Console.WriteLine("sayı doğru ");
            //} else {
            //    Console.WriteLine("sayı hatalı ");
            //}


            //ornek4

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average= (exam1+exam2+exam3)/3;

            //Console.WriteLine("sınavların ortalaması : " + average);

            //if (average>0 & average<=50)
            //{
            //    result = "sonuç kötü";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //else
            //{
            //    result = "geçersiz sonuç";
            //}

            //Console.WriteLine(result);


            //ornek5

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city =="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //ornek6


            //Console.Write("lütfen kullanıcı adı giriniz: ");
            //string username= Console.ReadLine();

            //if (username!="admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı geçersiz");
            //}
            //else
            //{
            //    Console.WriteLine("hoş geldinizzz");
            //}






            #endregion

            #region mod işlemleri

            //ornek1
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //ornek2


            //Console.Write("lütfen bir sayı giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı giriniz: ");
            //int number2= int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan: "+result);


            //ornek3
            //Console.Write("lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else {

            //    Console.WriteLine("sayı tektir");
            //}


            #endregion

            #region Char Değişkenleri ile Karar Yapıları


            //ornek4

            //char team;
            //Console.Write("lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team =='G' | team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****C# Eğitim Kampı Restoran****");


            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") {

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Kuru Fasule Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case


            //Console.Write("Lütfen ay girişi yapınız: ");
            //int montNumber=int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1: Console.WriteLine("ocak");break;
            //    case 2: Console.WriteLine("şubat");break;
            //    case 3: Console.WriteLine("mart");break;
            //    case 4: Console.WriteLine("nisan");break;
            //    case 5: Console.WriteLine("mayıs");break;
            //    case 6: Console.WriteLine("haziran");break;
            //    case 7: Console.WriteLine("temmuz");break;
            //    case 8: Console.WriteLine("ağustos");break;
            //    case 9: Console.WriteLine("eylül");break;
            //    case 10: Console.WriteLine("ekim");break;
            //    case 11: Console.WriteLine("kasım");break;
            //    case 12: Console.WriteLine("aralık");break;
            //    default: Console.WriteLine("Hatalı veri girişi");break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("yapmak istediğiniz sembolü giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //    default:
            //        Console.WriteLine("geçersiz sembol");
            //        break;
            //}

            #endregion

            Console.Read();

        }
    }
}
