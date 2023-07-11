using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string userName;
            //Again:
            //Console.WriteLine("Enter User Name");
            //userName = Console.ReadLine();
            //if(userName.Length>=6)
            //{
            //   Console.WriteLine("Welcome:\t" + userName);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid User Name");
            //   goto Again;
            // }
            //string mystring = "Raj";
            //StringBuilder stringBuilder = new StringBuilder("Welcome");
            //stringBuilder.Append("To C#");
            //stringBuilder.Append("I am String Builder");
            //stringBuilder.Append("string:\t" + mystring);
            //Console.WriteLine(stringBuilder);
            //Console.ReadKey();
            DateTime matchDate = new DateTime(day: 13, month: 07, year: 2023);
            DateTime currentDate = DateTime.Now;
            TimeSpan ts = matchDate.Subtract(currentDate);
            Console.WriteLine("Days Remain " + ts.Days);
            Console.WriteLine("Days Remain" + ts.Hours);
            Console.WriteLine(ts.ToString());
            Console.ReadKey();
        }
    }
}
