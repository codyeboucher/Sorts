using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class BubbleSort
    {
        public static void Sort(int[] nums)
        {
            for(int i = nums.Length-1; i > 0; i--)
            {
                for(int k = 0; k < i; k++)
                {
                    if(nums[k] > nums[k + 1])
                    {
                        var temp = nums[k];
                        nums[k] = nums[k + 1];
                        nums[k + 1] = temp;
                    }
                }
            }
        }
    }
}
