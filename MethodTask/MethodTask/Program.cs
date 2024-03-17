using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.ci tapsirig
            //1. 2 string array-i içerisindeki ortaq elementleri tapib ekrana yazdiran metod;

            //string[] names1 = { "Sirac",  "Nezrin", "Aysu", "Aydan", "Ayse", };
            //string[] names2 = { "Aytac", "Zehra", "Aysu", "Emine", "Ayten", "Sirac" };
            //FindCommonElements(names1, names2);
            #endregion

            #region 2.ci tapsirig
            //2. 2 eyni uzunluqlu array içerisindeki elementlerin indexlerine uygun hasilini tapib ekrana yazdiran metod
            //(example : { 5 , 10 ,15}. ve { 2 , 4 , 5}. ==>  { 10 , 40 ,75 })
            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = { 6, 7, 8, 9, 10 };
            //FindProduct(numbers1, numbers2);
            #endregion

            #region 3.cu tapsirig
            //3. Array-in içerisinde verilmiş herf ile başlayanları ekrana yazdırsın
            //(example: { "Anar" , "Eli" , "Yusif" , "Arif" }   ==> Anar , Arif)

            //string[] names = { "Sirac", "Ayten", "Nezrin", "Aysu", "Sabina", "Aytac", "Aysel" };
            //FindNames(names);
            #endregion

            #region 4.cu tapsirig
            // 4.Area deyə Method(lar) yaradın
            //a.Çevrənin sahəsi -S = p * r² (p = 3)
            //b.Düzbucaqlının sahəsi -S = a * b
            //c.Düzbucaqlı paralelpipedin tam səthinin sahəsi - S = 2(a * b + a * c + b * c)
            //d.Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2

            //int area = Area(2,5,3,2);
            //Console.WriteLine("Area: " + area);
            #endregion
        }

        #region 1.ci tapsirig
        //static void FindCommonElements(string[] arr1, string[] arr2)
        //{
        //    bool f = true;
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        for (int j = 0; j < arr2.Length; j++)
        //        {
        //            if (arr1[i] == arr2[j])
        //            {
        //                Console.WriteLine("Common element: " + arr1[i]);
        //                f = false;
        //            }
        //        }
        //    }
        //    if(f)
        //    {
        //        Console.WriteLine("No common element");
        //    }
        //}
        #endregion

        #region 2.ci tapsirig
        //static void FindProduct(int[] arr1, int[] arr2)
        //{
        //    int arrLength = arr1.Length;
        //    int[] arrResult = new int[arrLength];
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        arrResult[i] += arr1[i] * arr2[i];
        //        Console.WriteLine(arrResult[i]);
        //    }
        //}
        #endregion

        #region 3.cu tapsirig
        //static void FindNames(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i][0] == 'A')
        //        {
        //            Console.WriteLine("Search name: " + arr[i]);
        //        }
        //    }
        //}
        #endregion

        #region 4.cu tapsirig
        //static int Area(int r) //a.Çevrənin sahəsi -S = p * r² (p = 3)
        //{
        //    int p = 3;
        //    int s = p * r * r;
        //    return s;
        //}

        //static int Area(int a, int b) //b.Düzbucaqlının sahəsi -S = a * b
        //{
        //    int s = a * b;
        //    return s;
        //}

        //static int Area(int a, int b, int c) //c.Düzbucaqlı paralelpipedin tam səthinin sahəsi - S = 2(a * b + a * c + b * c)
        //{
        //    int s = 2 * (a * b + a * c + b * c);
        //    return s;
        //}

        //static int Area(int a, int b, int c, int r) //d.Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2
        //{
        //    int p = (a + b + c) / 2;
        //    int s = p * r;
        //    return s;
        //}
        #endregion

    }
}
