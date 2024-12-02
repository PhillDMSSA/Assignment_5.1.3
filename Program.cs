using System.Collections.Generic;
using System.Reflection;

namespace Assignment_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            int[] nums2 = { 1, 2, 3, 4, 1 };

            Console.WriteLine(DuplicateNums(nums1));
            Console.WriteLine(DuplicateNums(nums2));

        }

        static bool DuplicateNums(int[] numbers)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (counter.ContainsKey(num))
                
                    return true;
                    counter[num] = 1;
                
                
            }
            return false;

        }
    }
}
