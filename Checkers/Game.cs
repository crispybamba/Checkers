using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Game
    {
        private Board board;
        

        public Game()
        {
            board = new Board();
            Player player1 = new Player(board, Input_color(), Input_name());
            Player player2 = new Player(board, !player1.GetColor(), Input_name());
        }


        private string Input_name()
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            return name;
        }

        private bool Input_color()
        {
            Console.WriteLine("what is your color?");
            string color = Console.ReadLine();
            if (color == "black" ||  color == "Black")
                return false;
            if (color == "white" || color == "White")
                return true;
            return true;

        }

    }
}