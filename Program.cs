using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Runtime.ExceptionServices;
using System.Collections.Generic;
using System.Xml.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        List<List<List<int>>> resultHourGlasses = new List<List<List<int>>>();
        List<int> sums = new List<int>();

        for (int x = 0; x <= 3; x++)
        {
            for (int y = 0; y <= 3; y++)
            {
                var hourGlass = GetHourGlass(new List<List<int>> { arr[x].GetRange(y, 3), arr[x + 1].GetRange(y, 3), arr[x + 2].GetRange(y, 3) });
                resultHourGlasses.Add(hourGlass);
            }
        }


        foreach (var item in resultHourGlasses)
        {
            //Console.WriteLine(GetHourGlassSum(item));
            sums.Add(GetHourGlassSum(item));
        }
        Console.WriteLine(sums.Max());

    }
    public static List<List<int>> GetHourGlass(List<List<int>> Arr)
    {


        var hourGlass = new List<List<int>>
        {
            Arr[0],
            new List<int> { Arr[1][1] },
            Arr[2]
        };
        return hourGlass;

    }


    public static int GetHourGlassSum(List<List<int>> Arr)
    {
        return (Arr[0].Sum() + Arr[1].Sum() + Arr[2].Sum());
    }
}
