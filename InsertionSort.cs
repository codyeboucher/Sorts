using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class InsertionSort
    {
        public static void Sort(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                var key = nums[i];
                var k = i;
                    while (k > 0 && key < nums[k - 1])
                    {
                        nums[k] = nums[k - 1];
                        k--;
                    }
                nums[k] = key;
            }
        }
    }
}