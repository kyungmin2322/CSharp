using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Player
    {
        public Player()
        {
            hp = 100;
            gold = -10;
            Console.WriteLine("플레이어 생성자");
        }

        public Player(int hp, int gold)
        {
            this.hp = hp;
            this.gold = gold;
        }

        ~Player()
        {
            // Network, DB 종료
            Console.WriteLine("플레이어 소멸자");
        }

        public int hp;
        public int gold;

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
