namespace CS20250218
{
    public class Program
    {
        static void Main(string[] args)
        {
            Engine.Instance.Load();
            Engine.Instance.Run();
        }
    }
}