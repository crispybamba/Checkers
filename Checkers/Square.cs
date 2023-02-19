using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Square
    {
        private Checker checker;

        public Square(bool color)
        {
            checker = new Checker(color);
        }
        public Checker GetChecker() => checker;
    }
}