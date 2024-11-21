using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _20241025_ifelse_TEST
{
    internal class Program
    {
       static int x=5, y = 9;
        static void Main(string[] args)
        {
            int x = 2, y = 3;
            int z=fun01(x,y);
            Console.WriteLine("x的值為:" + x.ToString() + "y的值為:" + y.ToString()+"x+y="+z.ToString());
            Console.WriteLine("x的值為{0:d5},y的值為{1:d5},x+y={2:d5}",x,y,z);
            Console.WriteLine("y的值為{1:d5},x的值為{0:d5},x+y={2:d5}", x, y, z);
            Console.WriteLine("x的值為{0:d5},y的值為{1:d5},x+y={2:d5}", x, y, fun01(x,y));

            float m = 2.51f, n = 2.22f;
            //double k = fun01(m, n);
            Console.WriteLine("m的值為{0:N3},n的值為{1:N3},m+n={2:N3}", m,n,fun01(m,n));
            Console.WriteLine("程式結束,按任意鍵....");
            Console.ReadLine();
        }

        static int fun01(int x,int y)  //加法
        {
            return (x + y);
        }
        static string fun01(string x,string y)
        {
            return (x.ToString()+ y.ToString());
        }
        static double fun01(double x,double y)
        {
            return(x + y);
        }
        static void fun01()  //加法
        {
            int x = 9, y = 12;
            Console.Write("x+y=");
            Console.WriteLine(x + y);
            Console.WriteLine("相加函式進來了!請按任意鍵");
            Console.ReadLine();
            Console.Clear();
        }
        static void fun02() //減法
        {
            Console.WriteLine("相減函式進來了!請按任意鍵");
            Console.ReadLine();
            Console.Clear();
        }
        static void fun03() //乘法
        {
            Console.WriteLine("相乘函式進來了!請按任意鍵");
            Console.ReadLine();
            Console.Clear();
        }
        static void fun04() //除法
        {
            Console.WriteLine("相除函式進來了!請按任意鍵");
            Console.ReadLine();
            Console.Clear();
        }
    }    
}
