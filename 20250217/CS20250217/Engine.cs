﻿using SDL2;
using System;

namespace CS20250217
{
    public class Engine
    {
        private Engine()
        {

        }

        static protected Engine instance;

        // 더블 버퍼링
        static public char[,] backBuffer = new char[20, 40];
		static public char[,] frontBuffer = new char[20, 40];

		static public Engine Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Engine();
                }
                return instance;
            }
        }

        protected bool isRunning = true;

        // 20250304 SDL 추가
        public IntPtr myWindow;
        public IntPtr myRenderer;
        public SDL.SDL_Event myEvent;

		// 20250304 SDL 추가
		public bool Init()
		{
			if(SDL.SDL_Init(SDL.SDL_INIT_EVERYTHING) < 0)
			{
				Console.WriteLine("Fail Init.");
				return false;
			}

			myWindow = SDL.SDL_CreateWindow(
				"Game",
				100, 100,
				640, 480,
				SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

			myRenderer = SDL.SDL_CreateRenderer(myWindow, -1,
				SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED |
				SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC |
				SDL.SDL_RendererFlags.SDL_RENDERER_TARGETTEXTURE);

			return true;
		}

		// 20250304 SDL 추가
		public bool Quit()
        {
            SDL.SDL_DestroyRenderer(myRenderer);
            SDL.SDL_DestroyWindow(myWindow);

            SDL.SDL_Quit();

            return true;
        }

		public void Load(string filename)
        {
            /*
			string tempScene = "";
			byte [] buffer = new byte [1024];
			FileStream fs = new FileStream("level01.map", FileMode.Open);

			fs.Seek(0, SeekOrigin.End);
			long fileSize = fs.Position;

			fs.Seek(0, SeekOrigin.Begin);
			int readCount = fs.Read(buffer, 0, (int)fileSize);
			tempScene = Encoding.UTF8.GetString(buffer);
            tempScene = tempScene.Replace("\0", "");
			string [] scene = tempScene.Split("\r\n");
            */

            List<string> scene = new List<string>();

            StreamReader sr = new StreamReader(filename);
            while(!sr.EndOfStream)
            {
                scene.Add(sr.ReadLine());
            }
            sr.Close();

			world = new World();
            
            for(int y = 0; y < scene.Count; y++)
            {
                for(int x = 0; x < scene[y].Length; x++)
                {
                    if (scene[y][x] == '*')
                    {
                        Wall wall = new Wall(x, y, scene[y][x]);
                        world.Instanciate(wall);
                    }
                    else if(scene[y][x] == ' ')
                    {
                        // Floor floor = new Floor(x, y, scene[y][x]);
                        // world.Instanciate(floor);
                    }
                    else if (scene[y][x] == 'P')
                    {
                        Player player = new Player(x, y, scene[y][x]);
                        world.Instanciate(player);
                    }
                    else if (scene[y][x] == 'M')
                    {
                        Monster monster = new Monster(x, y, scene[y][x]);
                        world.Instanciate(monster);
                    }
                    else if (scene[y][x] == 'G')
                    {
                        Goal goal = new Goal(x, y, scene[y][x]);
                        world.Instanciate(goal);
                    }
					Floor floor = new Floor(x, y, ' ');
					world.Instanciate(floor);
				}
			}
            // Loading Complete
            // sort
            world.Sort();
        }

		public void ProcessInput()
		{
			Input.Process();
		}

		protected void Update()
        {
            world.Update();
        }

        protected void Render()
		{
			// 20250304 SDL 추가
			SDL.SDL_SetRenderDrawColor(myRenderer, 0, 0, 0, 0);
            SDL.SDL_RenderClear(myRenderer);

            // IO 제일 느림, 모니터 출력, 메모리
            //Console.Clear();
            world.Render();

            // 메모리에 있는 것을 한 방에 붙여줌
            for(int Y = 0; Y < 20; ++Y)
            {
                for(int X = 0; X < 40; ++X)
                {
                    if(Engine.frontBuffer[Y, X] != Engine.backBuffer[Y, X])
                    {
                        Engine.frontBuffer[Y, X] = Engine.backBuffer[Y, X];
                        Console.SetCursorPosition(X, Y);
                        Console.Write(frontBuffer[Y, X]);
                    }
                }
            }

			// 20250304 SDL 추가
			SDL.SDL_RenderPresent(myRenderer);
        }

        // public DateTime lastTime;

		public void Run()
		{
			// 20250304 SDL 추가
			//float frameTime = 1000.0f / 60.0f;
			//float elapsedTime = 0;
			Console.CursorVisible = false;

			while(isRunning)
			{
                SDL.SDL_PollEvent(out myEvent);

				Time.Update();

                switch(myEvent.type)
                {
                    case SDL.SDL_EventType.SDL_QUIT:
                        isRunning = false;
                        break;
                }
				// 20250304 SDL 추가
				/*
				ProcessInput();
				Update();
				if(elapsedTime >= frameTime)
				{                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
					Render();
					elapsedTime = 0;
				}
				else
				{
					elapsedTime += Time.deltaTime;
				}
                */

                Update();
                Render();
			}
		}

		public World world;
    }
}
