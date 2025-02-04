namespace _20250204
{
    internal class C20250204
    {
        enum CardType
        {
            Heart,
            Diamond,
            Clover,
            Spade
        }
        static void Initialize(int[] deck)
        {
            for(int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }
        }

        static void Shuffle(int[] deck)
        {
            Random rnd = new Random();

            for (int i = deck.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);
                int temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp; 
            }
        }

        static CardType CheckCardType(int cardNum)
        {
            return (CardType)((cardNum - 1) / 13);
        }

        static string CheckCardName(int CardNum)
        {
            int cardValue = (CardNum - 1) % 13 + 1;

            switch (cardValue)
            {
                case 1:
                    return "A";
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                default:
                    return cardValue.ToString();
            }
        }

        // 카드 값 계산
        static int Calculator(int[] handCard)
        {
            int totalValue = 0;
            int aceCount = 0;

            foreach(int card in handCard)
            {
                int cardValue = (card - 1) % 13 + 1;
                if (cardValue == 1)
                {
                    aceCount++;

                    // 기본적으로 11로 계산
                    totalValue += 11;
                }
                // J, Q, K 처리
                else if (cardValue >= 11 && cardValue <= 13)
                {
                    totalValue += 10;
                }
                else totalValue += cardValue;
            }

            while(aceCount > 0 && totalValue > 21)
            {
                totalValue -= 10;
                aceCount--;
            }
            return totalValue;
        }

        static void PrintCard(int[] deck, int stageNum)
        {
            for (int i = 0; i < stageNum; i++)
                Console.WriteLine($"{CheckCardType(deck[i])} {CheckCardName(deck[i])}");
            Console.WriteLine("==========");
        }

        static void PlayGame()
        {
            int[] deck = new int[52];
            int[] playerDeck = new int[10];
            int[] computerDeck = new int[10];

            int cardNum = 0;

            Initialize(deck);
            Shuffle(deck);

            bool playerBust = false;

            while (true)
            {
                for (cardNum = 0; cardNum < 2; cardNum++)
                {
                    int i = cardNum * 2;
                    playerDeck[cardNum] = deck[i];
                    computerDeck[cardNum] = deck[i + 1];
                }
                Console.WriteLine("===플레이어의 패===");
                PrintCard(playerDeck, cardNum);
                Console.WriteLine("===딜러의 패===");
                PrintCard(computerDeck, cardNum);

                // 21점 초과하면 탈출
                if (playerBust) break;

                Console.WriteLine("HIT 하시겠습니까? ( Y / N )");
                string userInput = Console.ReadLine().ToUpper();

                // 플레이어 카드 계산
                if (userInput == "Y")
                {
                    playerDeck[cardNum] = deck[cardNum * 2];
                    PrintCard(playerDeck, cardNum);

                    if (Calculator(playerDeck) > 21)
                    {
                        playerBust = true;
                        Console.WriteLine("플레이어 카드 버스트!! 21이 초과되었습니다.");
                    }
                }
                else if (userInput == "N") break;
                else Console.WriteLine("잘못된 입력입니다. Y 혹은 N을 입력해주세요.");
                Console.Clear();
                
                // 딜러 카드 계산
                while (Calculator(computerDeck) < 17)
                {
                    computerDeck[cardNum] = deck[cardNum];
                    PrintCard(computerDeck, cardNum);

                    if (Calculator(computerDeck) > 21) GameOver(playerDeck, computerDeck);
                }
                cardNum++;
            }
            Console.Clear();

            PrintCard(playerDeck, cardNum);
            PrintCard(computerDeck, cardNum);

            GameOver(playerDeck, computerDeck);
        }

        static void PrintScore(int[] playerDeck, int[] computerDeck)
        {
            Console.WriteLine("플레이어 점수 : " + $"{Calculator(playerDeck)}"
                    + " / 딜러 점수 : " + $"{Calculator(computerDeck)}");
        }

        static void GameOver(int[] playerDeck, int[] computerDeck)
        {
            if(Calculator(playerDeck) > 21 && Calculator(computerDeck) > 21)
            {
                PrintScore(playerDeck, computerDeck);
                Console.WriteLine("===무승부===");
            }
            else if(Calculator(playerDeck) > 21)
            {
                PrintScore(playerDeck, computerDeck);
                Console.WriteLine("딜러 승리! 플레이어의 카드 버스트로 21이 넘었습니다.");
            }
            else if(Calculator(computerDeck) > 21)
            {
                PrintScore(playerDeck, computerDeck);
                Console.WriteLine("플레이어 승리! 딜러의 카드 버스트로 21이 넘었습니다.");
            }
            else if(Calculator(playerDeck) > Calculator(computerDeck))
            {
                PrintScore(playerDeck, computerDeck);
                Console.WriteLine("플레이어 승리! 플레이어의 카드 합이 21에 더 가깝습니다.");
            }
            else if(Calculator(playerDeck) < Calculator(computerDeck))
            {
                PrintScore(playerDeck, computerDeck);
                Console.WriteLine("딜러 승리! 딜러의 카드 합이 21에 더 가깝습니다.");
            }
            else
            {
                PrintScore(playerDeck, computerDeck);
                Console.WriteLine("===무승부===");
            } 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=====BLACK JACK!=====");
            Console.WriteLine("블랙잭 게임을 시작합니다.");

            while (true)
            {
                PlayGame();

                Console.WriteLine("계속 플레이하시겠습니까? ( Y / N )");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    break;
                }
                Console.Clear();
            }
            Console.WriteLine("게임을 종료합니다.");
        }
    }
}
