using SDL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class GameObject
    {
        public int X;
        public int Y;
        public char Shape; // Mesh, Sprite
        public int orderLayer;
        public bool isTrigger = false;
        public bool isCollide = false;

		// 20250304 SDL 추가
        public SDL.SDL_Color color;
        public int spriteSize = 15;

		public virtual void Update()
        {

        }

        public virtual void Render()
        {
            // X, Y 위치에 Shape 출력
            //Console.SetCursorPosition(X, Y);
            //Console.Write(Shape);
            Engine.backBuffer[Y, X] = Shape;

			// 20250304 SDL 추가
			SDL.SDL_SetRenderDrawColor(Engine.Instance.myRenderer,
				color.r, color.g, color.b, color.a);
			// SDL.SDL_RenderDrawPoint(Engine.Instance.myRenderer, X, Y);
			SDL.SDL_Rect myRect;
			myRect.x = X * spriteSize;
			myRect.y = Y * spriteSize;
			myRect.w = spriteSize;
			myRect.h = spriteSize;

			SDL.SDL_RenderFillRect(Engine.Instance.myRenderer, ref myRect);
		}

		public bool PredictCollision(int newX, int newY)
		{
			for(int i = 0; i < Engine.Instance.world.GetAllGameObjects.Count; ++i)
			{
				if(Engine.Instance.world.GetAllGameObjects[i].isCollide == true &&
						Engine.Instance.world.GetAllGameObjects[i].X == newX &&
						Engine.Instance.world.GetAllGameObjects[i].Y == newY)
				{
					return true;
				}
			}
			return false;
		}
	}
}
