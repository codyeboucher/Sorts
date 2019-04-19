using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class SelectionSort
    {
        public static void Sort(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                var min = i;
                for(int k = i+1; k < nums.Length; k++)
                {
                    if(nums[k] < nums[min])
                    {
                        min = k;
                    }
                }
                if(min != i)
                {
                    var temp = nums[i];
                    nums[i] = nums[min];
                    nums[min] = temp;
                }
            }
        }
    }
}
