using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class World
    {
        public GameObject[] gameObjects = new GameObject[100];
        int useGameObjectCount = 0;

        public void Instanciate(GameObject gameObject)
        {
            gameObjects[gameObjects.Length - 1] = gameObject;
            useGameObjectCount++;
        }

        public void Update()
        {
            for(int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Update();
            }
        }

        public void Render()
        {
            for(int i = 0; i < gameObjects.Length;i++)
            {
                gameObjects[i].Render();
            }
        }
    }
}
