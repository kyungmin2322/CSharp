using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    internal class Program
    {
        /*
        class Singleton
        {
            private Singleton()
            {

            }

            static Singleton instance;

            static public Singleton GetInstance()
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
        */
        static void Main(string[] args)
        {
            Engine.Instance.Load();
            Engine.Instance.Run();
            /*
            // Sort(정렬)
            int [] numbers = { 1, 5, 2, 3, 6, 7, 8, 10, 9 };

            // 1 -> 10 : 올림차순, ascending
            // 10 -> 1 : 내림차순, descending
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] - numbers[j] > 0) // == numbers[i] - numbers[j] > 0
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            */
            // engine.Stop();
        }
    }
}
