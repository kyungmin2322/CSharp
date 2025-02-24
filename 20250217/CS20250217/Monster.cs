using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class Monster : GameObject
    {
        private Random rand = new Random();
        public Monster(int inX, int inY, char inShape)
        {
            X = inX;
            Y = inY;
            Shape = inShape;
            orderLayer = 5;
        }

        public override void Update()
        {
            int newX = X;
            int newY = Y;
            int randomValue = rand.Next(0, 4);

            switch(randomValue)
            {
                case 0:
                    newY++;
                    break;
                case 1:
					newY--;
                    break;
                case 2:
                    newX++;
                    break;
                case 3:
                    newX--;
                    break;
            }

			if (!Engine.Instance.world.IsWall(newX, newY))
			{
				X = newX;
				Y = newY;
			}
		}
    }
}
