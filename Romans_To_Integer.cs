﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Romans_To_Integer
{

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(RomanToInt("D"));
    //}
    public static int RomanToInt(string s)
    {
        int sum = 0;
        Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
        for (int i = 0; i < s.Length; i++)
        {
            char currentRomanChar = s[i];
            romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
            if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
            {
                sum -= num;
            }
            else
            {
                sum += num;
            }
        }
        return sum;
    }
}