using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Character
    {
        // private int hp;

        //public int Hp
        //{
        //    get { return hp; }
        //    set { hp = value; }
        //}

        public int gold;
        public int hp
        {
            get;
            set;
        }

        public int GetHP() { return hp; }

        public void SetHP(int value) { hp = value; }

        public void Attack()
        {

        }

        public void Move()
        {
            Console.WriteLine("플레이어가 움직인다.");
        }

        public void Collect()
        {

        }

        public void Die()
        {

        }
    }
}
