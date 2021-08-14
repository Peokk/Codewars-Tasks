using System;
using System.Collections.Generic;

public class Kata
{
    public static string PigIt(string str)
    {
        string[] words = str.Split();

        for (int i = 0; i < words.Length; i++)
        {
            char[] word = words[i].ToCharArray();
            char[] memory = words[i].ToCharArray();
            for (int j = 1; j < word.Length; j++)
                word[j - 1] = memory[j];
            word[word.Length - 1] = memory[0];

            if (new String(word) != "!" && new String(word) != "?")
                words[i] = new String(word) + "ay";
        }

        return string.Join(" ", words);
    }
}