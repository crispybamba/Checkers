using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Checker
    {
        private bool color; //white-True Black-False
        private bool isQueen;
        public Checker(bool color)
        {
            this.color = color;
        }
        public bool GetColor => color;
    }
}