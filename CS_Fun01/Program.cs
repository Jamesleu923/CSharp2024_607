using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_Fun01
{
    internal class Program
    {
        const double pi = 3.14159265359;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("h!");
            countsum04(5);
        }

        //回傳值型態不同,無傳入值的函式 樣態
        static void countsum01()
        {
            // void 不用return回傳, 也可以打 return; 結束,代表沒有回傳值
            return;
        }
        static int countsum02()
        {
            // 回傳值型別為int ,但pi為double,所以錯誤, 
            //return pi;
            // 修正: 使用強制轉型,把pi轉成整數型別
            return (int)pi;
        }
        static  double countsum03()
        {
            double r = 3;  //半徑為3
            return pi * r * r;
        }
        //}
        //回傳值型態不同,有傳入值的函式 樣態
        static void countsum04(int a)
        {
            //假設a為圓的半徑
            //本函式求圓的直徑
            // d:十進位數, g:一般顯示, n:小數點
            Console.WriteLine("countsum04 你的圓半徑為:{0:d3},直徑為{1:d3},面積為:{2:n2}", a, 2 * a, pi*a*a);
        }
        static int countsum05(float b)
        {

            return (int)(2 * b);
        }
        static double countsum06(float a, int b, char k)
        {
            // 回傳a-b
           Console.WriteLine("字元為{0:g}", k);
            double c = (double)a - (double)b;
            return c;
        }
        static double countsum07(double m, double n)
        {
            return m + n;
        }



    }
}
