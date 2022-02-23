using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Array.Sort(numbers);
            var index = Binary_Search(numbers, 3);
            Console.WriteLine(index);
            Console.ReadLine();
        }

        private static int Binary_Search(int[] nums, int target)
        {
            
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }

                if(target < nums[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }

            }
            return -1;
        }
    }
}
