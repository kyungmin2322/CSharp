using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Slime : Monster
    {
        public Slime()
        {
            Console.WriteLine("슬라임 생성자");
        }
        ~Slime()
        {
            Console.WriteLine("슬라임 소멸자");
        }
        public override void Move()
        {
            Console.WriteLine("슬라임이 미끄러진다.");
        }
    }
}
