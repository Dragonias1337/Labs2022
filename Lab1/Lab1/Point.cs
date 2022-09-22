using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Point
    {
        private int xcord, ycord;
        public int Xcord { get => xcord; }
        public int Ycord { get => ycord; }

        public Point(int xcord, int ycord)
        {
            this.xcord = xcord;
            this.ycord = ycord;
        }
    }
}
