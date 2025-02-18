using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218
{
    public class Input
    {
        static protected ConsoleKeyInfo keyInfo;

        public Input()
        {

        }

        static public void Process()
        {
            keyInfo = Console.ReadKey();
        }

        static public bool GetKeyDown(ConsoleKey key)
        {
            return (keyInfo.Key == key);
        }
    }
}
