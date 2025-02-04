namespace _20250204
{
    internal class C20250204
    {
        static void Main(string[] args)
        {
            int[] deck = new int[52];

            for(int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }

            // Shuffle
            Random random = new Random();

            for(int i = 0; i < deck.Length * 10; i++)
            {
                int firstCard = random.Next(0, deck.Length);
                int secondCard = random.Next(0, deck.Length);

                int temp = deck[firstCard];
                deck[firstCard] = deck[secondCard];
                deck[secondCard] = temp;
            }

            // Print
            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine(deck[i]);
            }
        }
    }
}
