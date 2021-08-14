using System;

public class Line
{
    public static string Tickets(int[] peopleInLine)
    {
        int numberOf25 = 0;
        int numberOf50 = 0;
        string canGiveChange;

        for (int i = 0; i < peopleInLine.Length; i++)
        {
            canGiveChange = "NO";

            if (peopleInLine[i] == 25)
            {
                numberOf25++;
                canGiveChange = "YES";
            }

            if (peopleInLine[i] == 50 && numberOf25 > 0)
            {
                numberOf50++;
                numberOf25--;
                canGiveChange = "YES";
            }

            if (peopleInLine[i] == 100)
            {
                if (numberOf25 > 0 && numberOf50 > 0)
                {
                    numberOf25--;
                    numberOf50--;
                    canGiveChange = "YES";
                }
            }

            if (peopleInLine[i] == 100 && numberOf25 > 2)
            {
                numberOf25 -= 3;
                canGiveChange = "YES";
            }

            if (canGiveChange == "NO")
                return "NO";
        }

        return "YES";
    }
}