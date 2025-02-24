namespace CS20250224
{
    class Program
    {
        static void Main(string[] args)
        {
			/* 1교시
			int n = Convert.ToInt32(Console.ReadLine());

			if ( n >= 1 && n <= 16 )
			{
				int [] arr1 = new int [n];
				int [] arr2 = new int [n];

				for ( int i = 0; i < n; i++ )
				{
					arr1 [i] = Convert.ToInt32(Console.ReadLine());
				}
				for ( int i = 0; i < n; i++ )
				{
					arr2 [i] = Convert.ToInt32(Console.ReadLine());
				}

				for ( int i = 0; i < n; i++ )
				{
					for(int j = 0; j < n; j++)
					{
						Console.Write((uint)( arr1 [i] | arr2 [i] ) > 0 ? '#' : ' ');
					}
					Console.WriteLine();
				}
			}
			else return;
			*/
			/* 2교시
			int n = 5;
			int [] arr1 = { 9, 20, 28, 18, 11 };
			int [] arr2 = { 30, 1, 21, 17, 28 };

			// 첫번째 방법
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine(Convert.ToString(arr1 [i] | arr2 [i], 2)
					.Replace('1', '#').Replace('0', ' '));
			}
			// 두번째 방법
			// int bitmask = 0b00000001;
			// for(int i = 0; i < n; i++) 
			// {
			//		bitmask = 1 << (n - 1);
			//		for(int j = 0; j < n; j++)
			//		{
			//			Console.Write((bitmask & result[i]) > 0 ? "#" : " ");
			//			bitmask = bitmask >> 1;
			//		}
			//		Console.Write(", ");
			// }
			*/
			/* 3교시
			uint N = 3;
			uint.TryParse(Console.ReadLine(), out N);

			ulong [] X = new ulong[N];

			for(int i = 0; i < N; i++)
			{
				ulong.TryParse(Console.ReadLine(), out X[i]);
			}

			ulong result = 0;
			for(int i = 0; i < N; i++)
			{
				ulong value = 1;
				for(int n = 1; n < 64; n++)
				{
					value = value << 1;
					if ( X [i] < value)
					{
						result = result ^ value;
						break;
					}
				}
			}
			Console.WriteLine(result);
			*/

			// bit
			// >> 2 / 2 / 2 2^-n
			// << 2 * 2 * 2 => 2^n
			// |, &, ~, ^


		}
    }
}
