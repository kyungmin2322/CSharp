using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Monster
    {
        public Monster()
        {
            Console.WriteLine("몬스터 생성자");
        }

        ~Monster()
        {
            Console.WriteLine("몬스터 소멸자");
        }

        public int hp;
        public int gold;

        public void Attack()
        {
            Console.WriteLine("몬스터가 공격한다.");
        }

        public virtual void Move()
        {
            Console.WriteLine("몬스터가 걷는다.");
        }

        public void Die()
        {
            Console.WriteLine("몬스터가 죽었다.");
        }
    }
}
