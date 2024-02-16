using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Fizz_Buzz
{
    //public static void Main(string[] args)
    //{
    //    foreach (var arg in FizzBuzz(3)) { Console.WriteLine(arg); }
    //}

    public static IList<string> FizzBuzz(int n)
    {

        List<string> outputs = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 & i % 5 == 0)
            { outputs.Add("FizzBuzz"); }
            else if (i % 3 == 0)
            { outputs.Add("Fizz"); }
            else if (i % 5 == 0)
            { outputs.Add("Buzz"); }
            else { outputs.Add(i.ToString()); }
        }


        return outputs;
    }


}

