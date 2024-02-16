using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hour_Glasses_challenge
{
    public class Two_Sum_Input_Array_Is_Sorted
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(TwoSum([2,7,11,15] ,9));
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < numbers.Length - 1 && right > 0)
            {
                while ((numbers[left] + numbers[right]) > target)
                { right--; }
                while ((numbers[left] + numbers[right]) < target)
                { left++; }
                if ((numbers[left] + numbers[right]) == target)
                { return [left + 1, right + 1]; }
               
            }
            return [-1, -1];
        }
    }
}
