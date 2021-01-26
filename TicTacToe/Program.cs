using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = IntializeBoard();
            DisplayBoard(IntializeBoard());
            string input = "2,2";
            int x = Int32.Parse(input.Split(',')[0]);
            int y = Int32.Parse(input.Split(',')[1]);
            if(IsValidMove(board, x, y) && IsValidInput(input))
            {
                PlaceOnBoard(ref board, 'X', x, y);
                DisplayBoard(board);
            }

        }

        static void DisplayBoard(char[,] board)
        {
           Console.Clear();
           for(int i = 0; i < 3; i++)
           {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {board[i, j]} ");
                    if (j < 2)
                        Console.Write("|");
                }
                Console.WriteLine("");
           }
        }

        static char[,] IntializeBoard()
        {
            char[,] board = new char[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i,j] = '-';
                }
            }
            return board;
        }

        static void PlaceOnBoard(ref char[,] board, char token, int x, int y)
        {
            board[y, x] = token;
        }

        static bool IsValidMove(char[,] board, int x, int y) => board[y, x] == '-';
        static bool IsValidInput(string input) => input.Split(',').Length == 2 && Int32.Parse(input.Split(',')[0]) < 3 && Int32.Parse(input.Split(',')[1]) < 3;
    }
}
