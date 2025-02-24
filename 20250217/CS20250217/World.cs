using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20250217
{
    public class World
    {
        // public GameObject[] gameObjects = new GameObject[100];
        List<GameObject> gameObjects = new List<GameObject>();

        public void Instanciate(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public void Update()
        {
            for(int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();
            }
        }

        public void Render()
        {
            for(int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Render();
            }
        }
    }
}
