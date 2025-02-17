using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Load();

            engine.Run();

            // engine.Stop();
        }
    }
}
