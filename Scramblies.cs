using System;
public class Scramblies
{

    public static bool Scramble(string str1, string str2)
    {
        char[] s1 = str1.ToCharArray();    char[] s2 = str2.ToCharArray();
        int x = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            for (int j = 0; j < s2.Length; j++)
            {
                if(s1[i] == s2[j])
                {
                    s1[i] = '1';
                    s2[j] = '2';
                    x++;

                    j = 0;
                    
                }            
            }
        }

        if (x == s2.Length)
            return true;
        return false;
    }
}