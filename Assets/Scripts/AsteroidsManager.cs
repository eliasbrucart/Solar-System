using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsManager : MonoBehaviour
{
    public GameObject asteroidsPrefab;
    public List<GameObject> asteroidsCreated = new List<GameObject>();
    public int amountOfAsteroids = 0;

    public float timeRemaining = 10.0f;
    public float timeToDestroy = 0.0f;

    private bool checkAsteroids = false;

    void Start()
    {
    }

    
    void Update()
    {
        timeToDestroy += Time.deltaTime;
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        if(timeRemaining <= 0)
        {
            if(checkAsteroids == false)
            {
                for (int i = 0; i < amountOfAsteroids; i++)
                {
                    float randomX = Random.Range(-500.0f, 500.0f);
                    float randomZ = Random.Range(-500.0f, 500.0f);
                    GameObject go = Instantiate(asteroidsPrefab, new Vector3(randomX, 100.0f, randomZ), Quaternion.identity);
                    asteroidsCreated.Add(go);
                    if(asteroidsCreated.Count == amountOfAsteroids)
                    {
                        checkAsteroids = true;
                    }
                }
            }
        }
        if (timeToDestroy >= 20.0f)
        {
            for(int i = 0; i < amountOfAsteroids; i++)
            {
                GameObject.Destroy(asteroidsCreated[i].gameObject);
                asteroidsCreated.RemoveAt(i);
            }
        }
    }
}
