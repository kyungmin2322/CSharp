using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDL2.SDL;

namespace CS20250217
{
	public class Player : GameObject
    {
		private float elapsedTime = 0;

        public Player(int inX, int inY, char inShape)
        {
            X = inX;
            Y = inY;
            Shape = inShape;
            orderLayer = 4;
            isTrigger = true;

			// 20250304 SDL 추가
			color.r = 0;
			color.g = 0;
			color.b = 255;

			colorKey.r = 255;
			colorKey.g = 0;
			colorKey.b = 255;
			colorKey.a = 255;

			isAnimation = true;

			LoadBmp("data/player.bmp");
		}

		public override void Update()
		{
			if(elapsedTime >= 500.0f)
			{
				if(Input.GetKeyDown(SDL_Keycode.SDLK_w) || Input.GetKeyDown(SDL_Keycode.SDLK_UP))
				{
					if(!PredictCollision(X, Y - 1))
					{
						Y--;
					}
					spriteIndexY = 1;
				}
				if(Input.GetKeyDown(SDL_Keycode.SDLK_s) || Input.GetKeyDown(SDL_Keycode.SDLK_DOWN))
				{
					if(!PredictCollision(X, Y + 1))
					{
						Y++;
					}
					spriteIndexY = 3;
				}
				if(Input.GetKeyDown(SDL_Keycode.SDLK_a) || Input.GetKeyDown(SDL_Keycode.SDLK_LEFT))
				{
					if(!PredictCollision(X - 1, Y))
					{
						spriteIndexY = 0;
						X--;
					}
				}
				if(Input.GetKeyDown(SDL_Keycode.SDLK_d) || Input.GetKeyDown(SDL_Keycode.SDLK_RIGHT))
				{
					if(!PredictCollision(X + 1, Y))
					{
						spriteIndexY = 1;
						X++;
					}
				}
			}
		}
	}
}
