using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class QuickSort
    {
        public static void Sort(int[] nums, int start, int end)
        {
            if(start < end)
            {
                var pivot = Partition(nums, start, end);
                Sort(nums, start, pivot - 1);
                Sort(nums, pivot + 1, end);
            }
        }

        private static int Partition(int[] nums, int start, int end)
        {
            int index = start;
            int pivot = nums[end];

            for(int i = start; i < end; i++)
            {
                if(nums[i] < pivot)
                {
                    Swap(nums, nums[i], nums[index]);
                    index++;
                }
            }

            Swap(nums, index, end);
            return index;
        }

        private static void Swap(int[] nums, int first, int second)
        {
            var temp = nums[first];
            nums[first] = nums[second];
            nums[second] = temp;
        }
    }
}
