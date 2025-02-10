namespace _20250210
{
    class Apple
    {
        public enum EColor
        {
            Red,
            Green,
            Blue,
            Yellow,
            White,
        };

        public EColor color;
        public bool taste;
        public int shape;
        public int hp = 100;

        public void CanEat()
        {
            hp -= 10;
            Console.WriteLine($"현재 HP {hp}");
        }
        public void Drop(Position target)
        {

        }

        public static void Die()
        {
            Console.WriteLine("죽었다.");
        }
    }

    struct Position
    {
        public int x;
        public int y;
    }

    internal class C20250210
    {
        static void Main(string[] args)
        {
            //Position[] positions = new Position[10];
            //positions[0].x = 12;
            //positions[0].y = 12;

            //Apple[] apple = new Apple[3]; // stack 참조 변수
            //for(int i = 0; i < apple.Length; i++)
            //{
            //    apple[i] = new Apple(); // heap apple 형태 메모리 공간 확보
            //}

            //apple[0].color = Apple.EColor.Yellow;
            //apple[1].color = Apple.EColor.Yellow;
            //apple[2].color = Apple.EColor.Yellow;

            //apple[0].CanEat();

            Apple.Die();
        }
    }
}
