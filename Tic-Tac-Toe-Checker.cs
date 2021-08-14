using System;

public class TicTacToe
{
    public int IsSolved(int[,] board)
    {
        string str = "";
        for (int i = 0; i < 3; i++)      
            for (int j = 0; j < 3; j++)         
                str += board[i, j];

        //If win
        for (int i = 0; i < 3; i++)
        {
            if (str[i] == '1' && str[i + 3] == '1' && str[i + 6] == '1') return 1;
            else if (str[i] == '2' && str[i + 3] == '2' && str[i + 6] == '2') return 2;
        }

        for (int i = 0; i < 7; i += 3)
        {
            if (str[i] == '1' && str[i + 1] == '1' && str[i + 2] == '1') return 1;
            if (str[i] == '2' && str[i + 1] == '2' && str[i + 2] == '2') return 2;
        }

        if (str[0] == '1' && str[4] == '1' && str[8] == '1') return 1;
        else if (str[0] == '2' && str[4] == '2' && str[8] == '2') return 2;
        if (str[2] == '1' && str[4] == '1' && str[6] == '1') return 1;
        else if (str[2] == '2' && str[4] == '2' && str[6] == '2') return 2;

        //If empty
        if (str.Contains("0")) return -1;

        //If draw
        return 0;
    }
}