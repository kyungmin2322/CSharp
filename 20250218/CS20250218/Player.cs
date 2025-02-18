using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218
{
    public class Player : GameObject
    {
        public Player(int X, int Y, char Shape)
        {
            this.X = X;
            this.Y = Y;
            this.shape = Shape;
        }

        public override void Update()
        {
            int inX = X;
            int inY = Y;

            if (Input.GetKeyDown(ConsoleKey.W) || Input.GetKeyDown(ConsoleKey.UpArrow))
            {
                inY--;
            }
            if (Input.GetKeyDown(ConsoleKey.S) || Input.GetKeyDown(ConsoleKey.DownArrow))
            {
                inY++;
            }
            if (Input.GetKeyDown(ConsoleKey.A) || Input.GetKeyDown(ConsoleKey.LeftArrow))
            {
                inX--;
            }
            if (Input.GetKeyDown(ConsoleKey.D) || Input.GetKeyDown(ConsoleKey.RightArrow))
            {
                inX++;
            }

            // 벽 충돌 감지
            if (Engine.Instance.scene[inY][inX] != '*')
            {
                X = inX;
                Y = inY;
            }

            // 몬스터 충돌 감지
            if (Engine.Instance.scene[Y][X] == 'M')
            {
                Engine.Instance.GameOver();
                return;
            }

            // 골 충돌 감지
            if (Engine.Instance.scene[Y][X] == 'G')
            {
                Engine.Instance.GameClear();
                return;
            }
        }
    }
}
