using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingTimesInputToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            int count = 0;

            countString(str, count);
        }

        static void countString(string[] arr, int x)
        {
            Console.WriteLine("Nhap cac ki tu: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToString(Console.ReadLine());
                x++;
            }
            Console.WriteLine("Count: " + x);
        }
    }
}
