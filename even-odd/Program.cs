using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //輸入一串以逗號分隔的整數數字字串，將其依照奇偶數分割為兩個數列，並且予以排序顯示結果
            Console.WriteLine("輸入一段字串以逗號分隔");
            

            string[] num = Console.ReadLine().Split(',');

            var even = num.Where(x => int.Parse(x) % 2 ==0);
            var odd = num.Where(x => int.Parse(x) % 2 != 0);
            Console.WriteLine($"偶數:{string.Join(",",even)}"); //string.Join 串連字串，並分隔符號
            Console.WriteLine($"奇數:{string.Join(",",odd)}");
            
            
            Console.ReadKey();
        }
    }
}
