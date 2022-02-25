
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -4, -1, 0, 3, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
               
                arr[i] = GetPow(arr[i], 2);
              
            }
            Array.Sort(arr);
            for (int l = 0; l < arr.Length; l++)
            {

                Console.WriteLine(arr[l]);

            }
            Console.ReadLine();
        }
        static int GetPow(int BaseNum,int PowNum)
        {
            int result = 1;
            for (int i = 0; i < PowNum; i++)
            {
                result *= BaseNum;
            }
            return result;
        }
    }
}
/*Simple solution
 for (int i = 0; i < arr.Length; i++)
            {
               
                arr[i] = arr[i]*arr[i];
              
            }
            Array.Sort(arr);
          return arr;
 */