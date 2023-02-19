using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Player
    {
        private bool color;
        private string name;
        private List<Checker> checkers;
        private bool turn;

        public Player(Board board, bool color, string name)
        {
            this.color = color;
            this.name = name;
            this.checkers = board.GetColorList(color);
            turn = false;
        }
        public bool GetColor() => color;
        public bool HasCheckers() { return checkers.Count() > 0; }
        public void RemoveChecker(Checker c) { checkers.Remove(c); }
    }
}