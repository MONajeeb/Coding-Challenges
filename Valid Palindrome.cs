using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hour_Glasses_challenge
{
    public class Valid_Palindrome
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        //}

        public static bool IsPalindrome(string s)
        {

            //string result = "";
            //string reversed = "";
            string nonAlpha = @" ,@#:.$_{}[]'""-?;!()`";
            // foreach(char c in s)
            // {
            //         if(!nonAlpha.Contains(c))
            //         {
            //             result += c;
            //         }
            // }
            // for (int i=result.Length - 1 ; i >=0 ; i -- )
            // {
            //     reversed += result[i];
            // }
            // if (result.ToLower() == reversed.ToLower()){ return true ;}

            // return false ; 


            ////Two pointers 
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (nonAlpha.Contains(s[left]) && left < right) { left++; }
                while (nonAlpha.Contains(s[right]) && right > left) { right--; }
                if (char.ToLower(s[left]) != char.ToLower(s[right])) { return false; }
                left++;
                right--;
            }

            return true;
        }




    }
}
