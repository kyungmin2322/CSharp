using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218
{
    public class GameObject
    {
        public int X;
        public int Y;
        public char shape;

        public virtual void Update()
        {

        }

        public virtual void IsMonster()
        {

        }

        public virtual void IsGoal()
        {

        }

        public virtual void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(shape);
        }
    }
}
