﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Square : Figure
    {
        public Square() { }

        public Square(int x, int y, char sym)
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x + 1, y, sym);
            points[2] = new Point(x, y + 1, sym);
            points[3] = new Point(x + 1, y + 1, sym);
            Draw();
        }

        public override void Rotate(Point[] pList)
        {
            
        }
    }
}
