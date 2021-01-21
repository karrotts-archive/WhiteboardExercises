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
            string input = "";
            
        }

        static void DisplayBoard(char[,] board)
        {
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

        static bool IsValidMove(char[,] board, int x, int y) => board[y, x] == '-';
    }
}
