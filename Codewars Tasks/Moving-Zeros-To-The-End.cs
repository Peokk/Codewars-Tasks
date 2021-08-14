using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int counter = 0;
        string st = "";
        string st1 = "";

        for (int i = 0; i < arr.Length; i++)
            st += arr[i].ToString();

        char[] single = st.ToCharArray();

        for (int i = 0; i < single.Length; i++)
        {
            if (single[i] == '0')
                counter++;
            else
                st1 += single[i].ToString();
        }

        for (int i = 0; i < counter; i++)
            st1 += "0";

        int[] ret = new int[st1.Length];

        for (int i = 0; i < st1.Length; i++)
            ret[i] = Convert.ToInt32(st1[i].ToString());

        return ret;
    }
}