namespace CS20250211
{
    internal class CS20250211
    {
        static void Main(string[] args)
        {
            Monster[] monsters = new Monster[2];

            monsters[0] = new Goblin();
            monsters[1] = new Boar();

            monsters[0].Move();
            monsters[1].Move();
        }
    }
}
