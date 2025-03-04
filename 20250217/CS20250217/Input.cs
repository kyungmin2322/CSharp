﻿using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class Input
    {
        public Input()
        {

        }

        public static void Process()
		{
			// 20250304 SDL 추가
			/*
            if(Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
            }
            */
		}

		static protected ConsoleKeyInfo keyInfo;
		static public bool GetKeyDown(ConsoleKey key)
		{
			return (keyInfo.Key == key);
		}

		static public bool GetKeyDown(SDL.SDL_Keycode key)
        {
			// 20250304 SDL 추가
			if(Engine.Instance.myEvent.type
                == SDL.SDL_EventType.SDL_KEYDOWN)
            {
                return (Engine.Instance.myEvent.key.keysym.sym == key);
            }
            return false;
        }

		// 20250304 SDL 추가
		static public bool GetKey(SDL.SDL_Keycode key)
        {
            return (Engine.Instance.myEvent.key.keysym.sym == key);
        }

		// 20250304 SDL 추가
		static public bool GetKeyUp(SDL.SDL_Keycode key)
        {
			if(Engine.Instance.myEvent.type
				== SDL.SDL_EventType.SDL_KEYUP)
			{
				return (Engine.Instance.myEvent.key.keysym.sym == key);
			}
			return false;
		}

		public static void ClearInput()
		{
			keyInfo = new ConsoleKeyInfo();
		}
	}
}
