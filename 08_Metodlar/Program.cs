using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metodlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Yıldız");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();



            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar
            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMethod("Meriç GÖRGÜN");

            //void customerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surname);
            //}
            //customerCard("Meriç", "Görgün");
            //customerCard("Emir", "Kırtaş");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1,int num2,int num3)
            //{
            //    int result = num1+ num2+ num3;
            //    Console.WriteLine(result);
            //}
            //Sum(2, 3, 5);

            #endregion

            #region Geriye Değer Döndüren Metodlar

            //string customerName()
            //{
            //    return "Arzu Görgün";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren string Parametreli Metodlar

            //string countryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo="Ülke : " + countryName + " - Başkent : " + capital + " - Bayrak Rengi : " + flagColor;
            //    return cardInfo;
            //}
            //string x,y,z;
            //Console.Write("Ülke Adını Giriniz : ");
            //x= Console.ReadLine();
            //Console.Write("Başkenti Giriniz : ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz : ");
            //z= Console.ReadLine();

            //Console.WriteLine( countryCard(x,y,z));

            //Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı Beyaz"));



            #endregion

            #region Geriye Değer Döndüren int Parametreli Metodlar

            //int Sum(int num1,int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}
            //Console.WriteLine(Sum(85, 69));
            //Console.WriteLine(Sum(23, 12));
            //Console.WriteLine(Sum(44, 49));
            //Console.WriteLine(Sum(22, 156));
            //Console.WriteLine(Sum(1235, 61));


            #endregion

            #region Sınav Sonuçları Örneği

            //string ExamResult(string student,int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti ," + "Ortalama : " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi ," + "Ortalama : " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali",25,35,65));
            //Console.WriteLine(ExamResult("Meriç",85,35,65));
            //Console.WriteLine(ExamResult("Arzu",25,85,45));

            #endregion


            Console.Read();
        }
    }
}
