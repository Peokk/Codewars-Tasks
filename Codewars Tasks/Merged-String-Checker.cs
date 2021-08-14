using System;
using System.Collections.Generic;

public class StringMerger
{
    public static bool isMerge(string s, string part1, string part2)
    {
        List<char> list = new List<char>();
        list.AddRange((part1 + part2).ToCharArray());
        int counter = 0;
        string ps1 = "";

        if (s == part1 || s == part2)
            return true;
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(part1) || string.IsNullOrEmpty(part2))
            return false;
        for (int j = 0; j < part1.Length; j++)      
            ps1 += s[j];
        for(int k = 0; k < part2.Length; k++)
            if (part2[k] != s[k + (s.Length - part2.Length)] && part1 == ps1)
                return false;
        for (int i = 0; i < list.Count; i++)
        {
            if (s.Contains(list[i].ToString()))
            {
                list.RemoveAt(i);
                list.Insert(0, '#');
                counter++;              
            }
        }
        if (counter == s.Length)
            return true;

        return false;
  }
}