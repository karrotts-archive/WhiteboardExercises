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
            while (input != "exit")
            {
                Console.Write("Please input an x,y coordinate to place your token: ");
                input = Console.ReadLine();

                if (IsValidInput(input))
                {
                    (int, int) pair = GetPairs(input);
                    if (IsValidMove(board, pair.Item1, pair.Item2))
                    {
                        PlaceOnBoard(ref board, 'X', pair.Item1, pair.Item2);
                        DisplayBoard(board);
                    }
                } 
                else
                {
                    Console.WriteLine("-- Error: Invalid Input --");
                }

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
        static (int, int) GetPairs(string input) => (Int32.Parse(input.Split(',')[0]), Int32.Parse(input.Split(',')[1]));
    }
}
