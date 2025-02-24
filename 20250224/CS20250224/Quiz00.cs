//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CS20250224
//{
//	public class Quiz00
//	{
//		BitArray32 bitArray = new BitArray32();
//		// 0101
//		bitArray.On(3);
//            bitArray.On(1);
//			Console.WriteLine(Convert.ToString(bitArray.Data, 2));

//            bitArray.Off(3);
//			Console.WriteLine(Convert.ToString(bitArray.Data, 2));


//			// byte a = 0; // ==> 0000 0000
//			// a = 1 << 1; // ==> 0000 0001 -> 0000 0010

//			// << shift 연산자
//			// >>

//			// 0101
//			// 0110 & (논리곱), and
//			// 0100

//			// 0011
//			// 0101 | (논리합)
//			// 0111

//			// 0001 ~ (부정)
//			// 1110

//			// 0101
//			// 0011 ^ (XOR)
//			// 0110

//			// 0000 0000 -> 16진수
//			// F    F    -> Color
//			// 0xFF
//			// 255

//			//byte Player = 1; // => 0b0000 0001
//			//byte Camera = 2; // => 0b0000 0010
//			//byte UI =     4; // => 0b0000 0100
//			//byte Water =  8; // => 0b0000 1000

//			//// Player
//			//byte playerLayer = 0b00000000;
//			//            // => 0b00000001 |
//			//            // => 0b00000011
//			//playerLayer = (byte)(playerLayer | Player);
//			//playerLayer = (byte)(playerLayer | UI);

//			//// bit masking
//			//if( (playerLayer & (Camera | Player)) > (byte)0 )
//			//{

//			//}
//	}
//	class BitArray32
//	{
//		public uint Data;

//		public void On( int position )
//		{
//			if ( position > 0 && position <= 32 )
//			{
//				Data = Data | (uint)( 1 << position - 1 );
//			}
//		}
//		public void Off( int position )
//		{
//			if ( position > 0 && position <= 32 )
//			{
//				Data = Data & ~(uint)( 1 << position - 1 );
//			}
//		}
//		public bool Check( uint other )
//		{
//			return (int)( Data & other ) > 0 ? true : false;
//		}
//	}
//}
