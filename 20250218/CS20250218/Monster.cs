using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218
{
    public class Monster : GameObject
    {
        Random rand = new Random();
        public Monster(int X, int Y, char Shape)
        {
            this.X = X;
            this.Y = Y;
            this.shape = Shape;
        }

        public override void Update()
        {
            int randValue = rand.Next() % 4;
            int obstacle = 0;

            switch(randValue)
            {
                case 0:
                    obstacle = Y + 1;
                    if (Engine.Instance.scene[obstacle][X] != '*')
                    {
                        Y++;
                    }
                    break;
                case 1:
                    obstacle = Y - 1;
                    if (Engine.Instance.scene[obstacle][X] != '*')
                    {
                        Y--;
                    }
                    break;
                case 2:
                    obstacle = X + 1;
                    if (Engine.Instance.scene[Y][obstacle] != '*')
                    {
                        X++;
                    }
                    break;
                case 3:
                    obstacle = X - 1;
                    if (Engine.Instance.scene[Y][obstacle] != '*')
                    {
                        X--;
                    }
                    break;
            }
        }
    }
}
