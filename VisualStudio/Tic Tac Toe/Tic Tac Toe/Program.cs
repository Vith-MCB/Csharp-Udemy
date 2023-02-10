using System;

namespace Coding.Exercise
{
    public class TicTacToe
    {
        public static bool Checker(string[,] board)
        {
            //Checking diagonals
            if (board[0, 0].Equals(board[1, 1]) && board[0, 0].Equals(board[2, 2]))
            {
                return true;
            }
            if (board[2, 0].Equals(board[1, 1]) && board[2, 0].Equals(board[0, 2]))
            {
                return true;
            }

            //Checking horizontaly
            if (board[0, 0].Equals(board[0, 1]) && board[0, 0].Equals(board[0, 2])) { return true; }
            if (board[1, 0].Equals(board[1, 1]) && board[1, 0].Equals(board[1, 2])) { return true; }
            if (board[2, 0].Equals(board[2, 1]) && board[2, 0].Equals(board[2, 2])) { return true; }

            //Checking verticaly
            if (board[0, 0].Equals(board[1, 0]) && board[0, 0].Equals(board[2, 0])){ return true; }
            if (board[0, 1].Equals(board[1, 1]) && board[0, 1].Equals(board[2, 1])){ return true; }
            if (board[0, 2].Equals(board[1, 2]) && board[0, 2].Equals(board[2, 2])){ return true; }

            return false;
        }
    }
}
