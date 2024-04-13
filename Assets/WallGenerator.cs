using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject wallPrefab;
    public float wallProbability = 0.3f; 
    public int floorWidth = 30;
    public int floorLength = 30; 
    public float wallSpacing = 3f; 

    void Start()
    {
        for (int i = 0; i < floorWidth; i++)
        {
            for (int j = 0; j < floorLength; j++)
            {
                if (Random.value < wallProbability)
                {
                    Vector3 position = new Vector3(i * wallSpacing, (30+(Random.value *10)), j * wallSpacing);
                    Instantiate(wallPrefab, position, Quaternion.identity);
                }
            }
        }
    }
}