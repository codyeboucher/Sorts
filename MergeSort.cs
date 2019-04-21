using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class MergeSort
    {
        public static void Sort(int[] nums, int start, int end)
        {
            if(start < end)
            {
                var mid = (start + end) / 2;
                Sort(nums, start, mid);
                Sort(nums, mid + 1, end);
                Merge(nums, start, mid, end);
            }
        }

        public static void Merge(int[] nums, int start, int mid, int end)
        {
            var result = new int[(end - start) + 1];
            var resultCt = 0;
            var left = start;
            var right = mid + 1;

            while(left <= mid && right <= end)
            {
                result[resultCt++] = nums[left] < nums[right] ? nums[left++] : nums[right++];
            }

            while(left <= mid)
            {
                result[resultCt++] = nums[left++];
            }

            while(right <= end)
            {
                result[resultCt++] = nums[right++];
            }

            for(int i = 0; i < result.Length; i++)
            {
                nums[start++] = result[i];
            }
        }       
    }
}
