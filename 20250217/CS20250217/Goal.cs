using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class Goal : GameObject
    {
        public Goal(int inX, int inY, char inShape)
        {
            X = inX;
            Y = inY;
            Shape = inShape;
            orderLayer = 3;
            isTrigger = true;

            // 20250304 SDL 추가
            color.r = 0;
            color.g = 255;
            color.b = 255;

            LoadBmp("data/goal.bmp");
		}
	}
}
