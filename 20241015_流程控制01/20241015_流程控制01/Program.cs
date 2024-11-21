using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241015_流程控制01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Std_ID= "11094100";
            Console.WriteLine(Std_ID);
            bool error= false;

            if (Std_ID.Length < 10)
                error = true;
            
            if (Std_ID.Length > 10)
                error = true;

            if (error)
                Console.WriteLine("學號長度不對,長度應為10碼,您的長度有" + Std_ID.Length.ToString() + "碼");
            else
                Console.WriteLine("學號長度對了!");


            /*
            if ( (Std_ID.Length<10) || (Std_ID.Length > 10) )
            {
                Console.WriteLine("學號長度不對,長度應為10碼,您的長度有"+Std_ID.Length.ToString()+"碼");
            }
            else
            {
                Console.WriteLine("學號長度對了!");   
                Console.WriteLine("hello");
            }
            */
            Console.ReadLine();


        }
    }
}
