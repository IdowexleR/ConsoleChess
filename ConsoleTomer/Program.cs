using System;

namespace ConsoleTomer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[8, 8]
            {
                {"R", "P", null, null, null, null, "P", "R"},
                {null, "P", null, null, null, null, "P", null},
                {null, "P", null, null, null, null, "P", null},
                {null, "P", null, null, null, null, "P", null},
                {null, "P", null, null, null, null, "P", null},
                {null, "P", null, null, null, null, "P", null},
                {"P", "P", null, null, null, null, "P", "P"},
                {"R", "P", null, null, null, null, "P", "R"}
            };
            string currentPlayer = "white";

            while (true)
            {
                DrawBoard(board);

                Console.WriteLine($"{currentPlayer} player's turn");
                Console.Write("Enter move: ");
                string move = Console.ReadLine();

                string[] moveSplit = move.Split(" ");
                int fromRow = int.Parse(moveSplit[0][1].ToString()) - 1;
                int fromCol = int.Parse(moveSplit[0][0].ToString()) - 1;
                int toRow = int.Parse(moveSplit[1][1].ToString()) - 1;
                int toCol = int.Parse(moveSplit[1][0].ToString()) - 1;

                string piece = board[fromRow, fromCol];
                board[fromRow, fromCol] = null;
                board[toRow, toCol] = piece;

                currentPlayer = currentPlayer == "white" ? "black" : "white";
            }
        }

        static void DrawBoard(string[,] board)
        {
            Console.WriteLine("  1 2 3 4 5 6 7 8");
            for (int row = 0; row < 8; row++)
            {
                Console.Write(row + 1 + " ");
                for (int col = 0; col < 8; col++)
                {
                    Console.Write((board[row, col] ?? ".") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

