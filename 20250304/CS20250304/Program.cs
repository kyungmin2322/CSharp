﻿using SDL2;
using System.Numerics;

namespace CS20250304
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Unity 초기화
            if( SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING) < 0)
            {
                Console.WriteLine("Fail Init.");
            }

            // 설정파일 읽어오기

            // 창 만들기
            IntPtr myWindow =  SDL.SDL_CreateWindow(
                "Game",
                100, 100,
                640, 480,
                SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            // 붓
            IntPtr myRenderer = SDL.SDL_CreateRenderer(myWindow, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED |
                SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC |
                SDL.SDL_RendererFlags.SDL_RENDERER_TARGETTEXTURE);

            // 메세지 처리(사용자 처리가 추가 구조를 바꿈)
            SDL.SDL_Event myEvent;
            bool isRunning = true;
            Random rand = new Random();
            while(isRunning)
            {
                SDL.SDL_PollEvent(out myEvent);
                switch(myEvent.type)
                {
                    case SDL.SDL_EventType.SDL_QUIT:
                        isRunning = false;
                        break;
                }
                SDL.SDL_SetRenderDrawColor(myRenderer, 0, 51, 102, 0);
                SDL.SDL_RenderClear(myRenderer);

                for(int i = 0; i < 100; i++)
                {
					// 랜덤으로 100개 사각형 그리기
					// 색 칠하기
					// 원 그리기
					// 위에꺼 랜덤으로 다하기
					
					byte r = (byte)(rand.Next() % 256);
                    byte g = (byte)(rand.Next() % 256);
                    byte b = (byte)(rand.Next() % 256);

                    SDL.SDL_Rect myRect;
                    myRect.x = rand.Next() % 640 - 200;
                    myRect.y = rand.Next() % 480 - 200;
                    myRect.w = rand.Next() % 640;
                    myRect.h = rand.Next() % 480;

					SDL.SDL_SetRenderDrawColor(myRenderer, r, g, b, 0);

                    int type = rand.Next() % 3;
                    switch(type)
                    {
                        case 0:
							SDL.SDL_RenderDrawRect(myRenderer, ref myRect);

                            break;
                        case 1:
							SDL.SDL_RenderFillRect(myRenderer, ref myRect);
							break;
                        case 2:
							int step = 10;
							int x0 = myRect.x;
							int y0 = myRect.y;

							double radius = myRect.w;
							//시작 값
							int prevX = (int)(radius * Math.Cos(0 * (Math.PI / 180.0f)));
							int prevY = (int)(radius * Math.Sin(0 * (Math.PI / 180.0f)));
							for(int angle = 1; angle <= 360 + step; angle += step)
							{
								int x = (int)(radius * Math.Cos(angle * (Math.PI / 180.0f)));
								int y = (int)(radius * Math.Sin(angle * (Math.PI / 180.0f)));

								//SDL.SDL_RenderDrawPoint(myRenderer, x0 + x, y0 + y);
								SDL.SDL_RenderDrawLine(myRenderer, x0 + prevX, y0 + prevY, x0 + x, y0 + y);
								prevX = x;
								prevY = y;
							}
							break;
					}
				}
                /* DrawCircle
                int x0 = 320;
                int y0 = 240;
				SDL.SDL_SetRenderDrawColor(myRenderer, 0, 0, 0, 0);

				double radius = 30.0f;

				int prevX = (int)(radius * Math.Cos(0));
				int prevY = (int)(radius * Math.Sin(0));

				for(double i = 0; i <= 2.0f; i += 0.1f)
                {
                    int x = (int)(radius * Math.Cos(i));
					int y = (int)(radius * Math.Sin(i));

                    SDL.SDL_RenderDrawLine(myRenderer, x0 + prevX, y0 + prevY, x0 + x, y0 + y);
                    prevX = x;
                    prevY = y;
				}
                */


				SDL.SDL_RenderPresent(myRenderer);
            }
            
            // 종료
            SDL.SDL_DestroyWindow(myWindow);

            SDL.SDL_Quit();
        }
    }
}
