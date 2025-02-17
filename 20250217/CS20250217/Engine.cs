﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class Engine
    {
        protected bool isRunning = true;

        protected ConsoleKeyInfo keyInfo;

        public void Input()
        {
            keyInfo = Console.ReadKey();
        }

        public void Load()
        {
            // file에서 로딩
            string[] scene = {
                "**********",
                "*P       *",
                "*        *",
                "*        *",
                "*        *",
                "*    M   *",
                "*        *",
                "*        *",
                "*       G*",
                "**********"
            };

            world = new World();
            
            for(int y = 0; y < scene.Length; y++)
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
                        Floor floor = new Floor(x, y, scene[y][x]);
                        world.Instanciate(floor);
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
                }
            }
        }

        protected void Update()
        {
            world.Update();
        }

        protected void Render()
        {
            world.Render();
        }

        public void Run()
        {
            while(isRunning)
            {
                Input();
                Update();
                Render();
            }
        }

        public World world;
    }
}
