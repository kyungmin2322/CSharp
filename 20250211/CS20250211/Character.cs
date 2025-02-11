using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250211
{
    enum KIND
    {
        PLAYER = 0,
        GOBLIN = 1,
        SLIME = 2,
        BOAR = 3
    }
    public class Character
    {
        public int hp = 100;
        public int money;

        public void SetMoney()
        {

        }

        public void GetMoney()
        {

        }

        public void Attack()
        {

        }

        public void Move(int kind)
        {
            switch (kind)
            {
                case 0:
                    // 플레이어 이동
                    break;
                case 1:
                    // 걸어서 이동
                    break;
                case 2:
                    // 미끄러져 이동
                    break;
                case 3:
                    // 뛰어서 이동
                    break;
            }
        }

        public void Die()
        {
            if (hp <= 0)
            {
                return;
            }
        }
    }
}
