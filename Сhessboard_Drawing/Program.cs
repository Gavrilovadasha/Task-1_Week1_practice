using System;

class Chessboard
{
    static void Main()
    {
        char[,] board = new char[8, 8]
        {
            {'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r'},
            {'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P'},
            {'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R'}
        };

        Console.WriteLine("   a b c d e f g h");
        Console.WriteLine("  -----------------");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < 8; j++)
            {
                Console.Write("|" + board[i, j]);
            }
            Console.WriteLine("|");
            Console.WriteLine("  -----------------");
        }
    }
}