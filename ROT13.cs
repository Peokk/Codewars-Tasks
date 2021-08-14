public class Kata
{
    public static string Rot13(string input)
    {
        char[] firstAlphabet = "abcdefghijklm".ToCharArray(); char[] secondAlphabet = "nopqrstuvwxyz".ToCharArray();
        char[] firstAlphabetUpper = "ABCDEFGHIJKLM".ToCharArray(); char[] secondAlphabetUpper = "NOPQRSTUVWXYZ".ToCharArray();
        char[] message1 = input.ToCharArray();

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                if (message1[i] == secondAlphabet[j])
                {
                    message1[i] = firstAlphabet[j];
                    j = 13;
                }
                else if (message1[i] == firstAlphabet[j])
                {
                    message1[i] = secondAlphabet[j];
                    j = 13;
                }
                else if (message1[i] == secondAlphabetUpper[j])
                {
                    message1[i] = firstAlphabetUpper[j];
                    j = 13;
                }
                else if (message1[i] == firstAlphabetUpper[j])
                {
                    message1[i] = secondAlphabetUpper[j];
                    j = 13;
                }
            }
        }
        return new string(message1);
    }
}