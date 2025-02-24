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
		// List<GameObject> visibleList = new List<GameObject>();

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

        public void Sort()
        {
            // gameObjects.Sort();
			for ( int i = 0; i < gameObjects.Count; i++ )
			{
				for ( int j = i + 1; j < gameObjects.Count; j++ )
				{
                    if ( gameObjects[i].orderLayer - gameObjects[j].orderLayer > 0)
                    {
                        GameObject temp = gameObjects[i];
                        gameObjects[i] = gameObjects[j];
                        gameObjects[j] = temp;
                    }
				}
			}
		}
        
        public bool IsWall(int x, int y)
        {
            foreach(GameObject obj in gameObjects)
            {
                if(obj is Wall && obj.X == x && obj.Y == y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
