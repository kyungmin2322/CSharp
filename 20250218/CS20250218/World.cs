using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250218
{
    public class World
    {
        public GameObject[] gameObjects = new GameObject[100];
        int useGameObjectCount = 0;

        public void Instanciate(GameObject gameObject)
        {
            gameObjects[useGameObjectCount] = gameObject;
            useGameObjectCount++;
        }

        public void Update()
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Update();
            }
        }

        public void IsMonster()
        {
            for(int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].IsMonster();
            }
        }

        public void IsGoal()
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].IsGoal();
            }
        }
        public void Render()
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Render();
            }
        }
    }
}
