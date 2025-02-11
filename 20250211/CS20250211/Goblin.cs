using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Goblin
    {
        public Goblin()
        {
            Console.WriteLine("고블린 생성자");
        }
        ~Goblin()
        {
            Console.WriteLine("고블린 소멸자");
        }

        public int hp;
        public int gold;

        public void Attack()
        {

        }

        public void Move()
        {
            Console.WriteLine("고블린이 걷는다.");
        }

        public void Die()
        {

        }
    }
}
