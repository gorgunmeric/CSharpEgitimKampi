using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yanyana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt Alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion


            #region Yıldızlarla Dik üçgen yapma

            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j=1;j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Yıldızlarla ters Dik üçgen yapma

            //for(int i= 5; i>=1; i--)
            //  {
            //      for(int j=1;j<=i;j++)
            //      {
            //          Console.Write("*");
            //      }
            //      Console.WriteLine();
            //  }

            #endregion


            #region Yıldızlarla yarım elmas

            //for(int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int k = 4; k>=1; k--)
            //{
            //    for(int m =1; m<=k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion



            #region Yıldızlarla Baklava Dilimi yapma

            //int n = 5;

            ////üst kısmı
            //for(int i = 1; i <= n; i++)
            //{
            //    for(int j =n-1; j >0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k =1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////Alt kısmı
            //for(int i=n-1; i >=1; i--)
            //{
            //    for(int j =n-1;j >0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k =1; k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Piramit
            //int n = 5;

            //for(int i = 1; i <= n; i++)
            //{
            //    //Boşluklar için
            //    for(int j=n-i;j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for(int k=1;k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla ters Piramit
            //int n = 10;

            //for(int i = n; i >=1; i--)
            //{
            //    //boşluklar
            //    for(int j=n-i; j>=0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //Yıldızlar
            //    for(int k = 1; k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            Console.Read();
        }
    }
}
