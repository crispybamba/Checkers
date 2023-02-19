using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    internal class Square
    {
        private int row;
        private int column;
        private Checker c;

        public Square(int row,int column)
        {
            this.row = row;
            this.column = column;
        }
        public void SetChecker(Checker checker)
        {
            this.c = checker;
        }
                      
        public Checker GetSqure();
        public bool HasChecker()
        {
            return (c != null);
        }
        public Checker Remove()
        {
            if (!HasChecker())
                throw new Exception("Trying to remove a pieace that does not exist");
            Checker checker = this.c;
            this.c = null;
            return checker;
        }
        public Checker GetChecker() => c;
    }
}