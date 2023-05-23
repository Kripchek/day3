using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 == 0 && myArr[i] % 3 != 0)
                {
                    int a = myArr[i] * myArr[i];
                    Console.WriteLine(a);
                }
            }
        }
    }
}
