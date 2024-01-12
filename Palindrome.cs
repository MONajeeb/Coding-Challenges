using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Palindrome
{
    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(IsPalindrome(-1));
    //}
        public static bool IsPalindrome(int input)
    {
        int temp = input;
        int sum = 0;
        while (input > 0)
        {
            int rem = input % 10;
            sum = (sum * 10) + rem;
            Console.WriteLine(rem);
            input = input / 10;
        }

        if (temp == sum )
        {
            return true;
        }
        return false;

    }
}

