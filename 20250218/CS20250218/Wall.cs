﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218
{
    public class Wall : GameObject
    {
        public Wall(int X, int Y, char Shape)
        {
            this.X = X;
            this.Y = Y;
            this.shape = Shape;
        }
    }
}
