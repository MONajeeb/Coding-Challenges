using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Lon_Inc_Sub
{
    static int LengthOfLIS(int[] nums)
    {
        int longest = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int LTS = 1;
            int start = i;
            int end = i + 1;
            while (end < nums.Length)
            {
                if (nums[start] < nums[end])
                { LTS++; }
                //else {LTS =LTS - ;}
                start++;
                end++;
            };
            if (LTS > longest)
            { longest = LTS; }
        }
        return longest;
    }
}

