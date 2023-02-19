using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Player
    {
        private string color;
        private string name;
        private List<Checker> checkers;
        private bool turn;

        public Player(string color, string name)
        {
            this.color = color;
            this.name = name;
            checkers = new List<Checker>();
            turn = false;
        }
        public bool HasCheckers() { return checkers.Count() > 0; }
        public void RemoveChecker(Checker c) { checkers.Remove(c); }
    }
}