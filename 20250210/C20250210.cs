namespace _20250210
{
    public class Image
    {
        public Image()
        {
            X = 0;
            Y = 0;
            R = 255;
            G = 255;
            B = 255;
            Console.WriteLine("생성자");
        }
        ~Image()
        {
            Console.WriteLine("소멸자");
        }

        public int X;
        public int Y;
        public int R;
        public int G;
        public int B;
    }

    internal class C20250210
    {
        static void Main(string[] args)
        {
            Image[] images = new Image[2];
            images[0] = new Image();
            images[0].X = 0;
            images[0].Y = 0;
            images[0].R = 0;
            images[0].G = 0;
            images[0].B = 0;

            for(int i = 0; i < images.Length; i++)
            {

            }
        }
    }
}
