using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 public class ValidAnagram
{
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (t.Contains(s[i]))
                {
                    int index = t.IndexOf(s[i]);
                    t = t.Remove(index, 1); ;
                }

            }
            if (t == "") { return true; }
            return false;
        }
    }
