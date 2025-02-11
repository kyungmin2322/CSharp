using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    public class Monster : Character
    {
        public Monster()
        {
            Console.WriteLine("몬스터 생성자");
        }

        ~Monster()
        {
            Console.WriteLine("몬스터 소멸자");
        }
    }
}
