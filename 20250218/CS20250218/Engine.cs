using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218
{
    public class Engine
    {
        static protected Engine instance;
        public World world;

        public string[] scene;

        public bool isRunning = true;
        public bool isClear = false;

        protected Engine()
        {

        }

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
        public void ProcessInput()
        {
            Input.Process();
        }

        public void Load()
        {
            scene = new string[]{
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
                    if(scene[y][x] == '*')
                    {
                        Wall wall = new Wall(x, y, scene[y][x]);
                        world.Instanciate(wall);
                    }
                    else if(scene[y][x] == ' ')
                    {
                        Floor floor = new Floor(x, y, scene[y][x]);
                        world.Instanciate(floor);
                    }
                    else if(scene[y][x] == 'P')
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
        
        public void Update()
        {
            world.Update();
        }

        public void Render()
        {
            Console.Clear();
            world.Render();
        }

        public void GameOver()
        {
            isRunning = false;
            Console.Clear();
            Console.WriteLine("=====GameOver=====");
        }

        public void GameClear()
        {
            isClear = true; 
            Console.Clear();
            Console.WriteLine("=====GameClear=====");
        }

        public void Run()
        {
            while(isRunning)
            {
                if (isClear == true)
                {
                    Console.WriteLine("=====GameClear=====");
                    return;
                }
                ProcessInput();
                Update();
                Render();
            }
        }
    }
}
