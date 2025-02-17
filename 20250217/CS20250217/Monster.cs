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
        }

        public override void Update()
        {

            int randomValue = rand.Next(0, 3);

            switch(randomValue)
            {
                case 0:
                    Y++;
                    break;
                case 1:
                    Y--;
                    break;
                case 2:
                    X++;
                    break;
                case 3:
                    X--;
                    break;
            }
        }
    }
}
