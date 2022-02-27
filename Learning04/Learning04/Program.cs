using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 5,2,8,7,1};
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for(int l = i + 1; l < arr.Length; l++)
                {
                    if (arr[i] > arr[l])
                    {
                        temp = arr[i];
                        arr[i] = arr[l];
                        arr[l] = temp;
                    }
                }
            }
            for(int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(" "+arr[k]);
            }
            Console.ReadLine();
        }
    }
}
