using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 序列倒置1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //輸入一串以逗號分隔的字串，並將其反向顯示
            Console.WriteLine("請輸入一串字串，以逗號分隔");
            string number = Console.ReadLine();
            
            string [] num = number.Split(',');
            var result = num.Reverse(); //Reverse 反轉陣列順序

            Console.WriteLine(string.Join(",", result));


            Console.ReadKey();
        }
        
    }
    
}
