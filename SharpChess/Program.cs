using System;
using System.Collections.Generic;

namespace SharpChess
{


    static class Program
    {
        const byte PAWN = 1;
        const byte HORS = 2;
        const byte BISC = 3;
        const byte ROOK = 4;
        const byte QUEE = 5;
        const byte KING = 6;
        static char[] pieceToChar = new char[] { ' ', 'P', 'H', 'B', 'R', 'Q', 'K' };
        static byte[,] board = new byte[8,8];

        static void Main(string[] args)
        {
            InitBoard();
            ShowBoard();
        }

        static void InitBoard()
        {
            // White
            board[0, 0] = ROOK;
            board[0, 1] = HORS;
            board[0, 2] = BISC;
            board[0, 3] = KING;
            board[0, 4] = QUEE;
            board[0, 5] = BISC;
            board[0, 6] = HORS;
            board[0, 7] = ROOK;
            // Pawns
            board[1, 0] = PAWN;
            board[1, 1] = PAWN;
            board[1, 2] = PAWN;
            board[1, 3] = PAWN;
            board[1, 4] = PAWN;
            board[1, 5] = PAWN;
            board[1, 6] = PAWN;
            board[1, 7] = PAWN;

            // Black
            board[7, 0] = ROOK;
            board[7, 1] = HORS;
            board[7, 2] = BISC;
            board[7, 3] = KING;
            board[7, 4] = QUEE;
            board[7, 5] = BISC;
            board[7, 6] = HORS;
            board[7, 7] = ROOK;
            // Pawns
            board[6, 0] = PAWN;
            board[6, 1] = PAWN;
            board[6, 2] = PAWN;
            board[6, 3] = PAWN;
            board[6, 4] = PAWN;
            board[6, 5] = PAWN;
            board[6, 6] = PAWN;
            board[6, 7] = PAWN;
        }

        static LinkedList<(byte,byte,byte,byte)> Moves()
        {
            var list = new LinkedList<(byte, byte, byte, byte)>();
            for (int x = 0; x < 8; x++)
                for (int y = 0; y < 8; y++)
                    if (board[x, y] > 0)
                    {
                        var move = MoveFor(x, y);
                        
                    }
        }

        static void ShowBoard()
        {
            Console.WriteLine("+-+-+-+-+-+-+-+-+");
            for (int x = 0; x < 8; x++)
            {
                Console.Write('|');
                for (int y = 0; y < 8; y++)
                {
                    Console.Write(pieceToChar[board[x, y]]);
                    Console.Write('|');
                }
                Console.WriteLine();
                Console.WriteLine("+-+-+-+-+-+-+-+-+");
            }
        }
    }
}
