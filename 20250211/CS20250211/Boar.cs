using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Boar : Monster
    {
        public Boar()
        {
            Console.WriteLine("멧돼지 생성자");
        }
        ~Boar()
        {
            Console.WriteLine("멧돼지 소멸자");
        }
        public override void Move()
        {
            Console.WriteLine("멧돼지가 뛴다.");
        }
    }
}
