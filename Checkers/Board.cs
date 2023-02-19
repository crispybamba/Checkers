using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Checkers
{
    class Board
    {
        private Square[,] board;
        private bool[,] colors;
        List<Checker> white_checkers = new List<Checker>();
        List<Checker> black_checkers = new List<Checker>();


        public Board()
        {

            board = new Square[8, 8];



            int turn = 0;
            colors = new bool[8, 8];
            for (int row = 0; row < colors.GetLength(0); row++)
            {
                if (row % 2 == 0)
                    turn = 0;
                else
                    turn = 1;
                for (int col = 0; col < colors.GetLength(1); col++)
                {
                    if (turn == 0)
                    {
                        colors[row, col] = true;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("-");
                        turn++;
                    }
                    else
                    {
                        colors[row, col] = false;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("-");
                        turn--;
                    }


                }
                Console.WriteLine("");
            }//checking colors of squares

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (row <= 3 && colors[row, col])
                    {
                        board[row, col] = new Square(true);
                        white_checkers.Add(board[row, col].GetChecker());
                    }
                    if (row >= 6 && !colors[row, col])
                    {
                        board[row, col] = new Square(false);
                        black_checkers.Add(board[row, col].GetChecker());
                    }

                }
            }//adding the checkers

            


        }

        public List<Checker> GetColorList(bool color)
        {
            if (color)
                return white_checkers;
            if (!color)
                return black_checkers;
            return null;
        }

    }

}