using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Boar
    {
        public Boar()
        {
            Console.WriteLine("멧돼지 생성자");
        }
        ~Boar()
        {
            Console.WriteLine("멧돼지 소멸자");
        }

        public int hp;
        public int gold;

        public void Attack()
        {

        }

        public void Move()
        {
            Console.WriteLine("멧돼지가 뛴다.");
        }

        public void Die()
        {

        }
    }
}
