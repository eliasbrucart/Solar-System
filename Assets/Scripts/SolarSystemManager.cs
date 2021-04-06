using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolarSystemManager
{
    public class SolarSystemManager : MonoBehaviour
    {
        public int amountPlanets = 0;
        public GameObject[] planetsPrefabs;
        public List<GameObject> planetsCreated = new List<GameObject>();

        public Transform cam;

        private int planetIndex = 0;
        private float offset = 1.5f;

        void Start()
        {
            List<int> listNumbers = new List<int>();
            int random = 0;
            for (int i = 0; i < amountPlanets; i++)
            {
                do
                {
                    random = Random.Range(0, planetsPrefabs.Length);
                } while (listNumbers.Contains(random));
                listNumbers.Add(random);
                GameObject go = Instantiate(planetsPrefabs[listNumbers[i]]);
                planetsCreated.Add(go);
            }
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.Alpha0))
            {
                planetIndex = 0;
                Debug.Log("Tierra");
            }
            if (Input.GetKey(KeyCode.Alpha1))
            {
                planetIndex = 1;
                Debug.Log("Jupiter");
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                planetIndex = 2;
                Debug.Log("Mars");
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                planetIndex = 3;
                Debug.Log("Mercury");
            }
            if (Input.GetKey(KeyCode.Alpha4))
            {
                planetIndex = 4;
                Debug.Log("Neptune");
            }
            if (Input.GetKey(KeyCode.Alpha5))
            {
                planetIndex = 5;
                Debug.Log("Pluton");
            }
            if (Input.GetKey(KeyCode.Alpha6))
            {
                planetIndex = 6;
                Debug.Log("Saturn");
            }
            if (Input.GetKey(KeyCode.Alpha7))
            {
                planetIndex = 7;
                Debug.Log("Uranus");
            }
            if (Input.GetKey(KeyCode.Alpha8))
            {
                planetIndex = 8;
                Debug.Log("Venus");
            }
        }

        void LateUpdate()
        {
            cam.transform.position = planetsCreated[planetIndex].transform.position;
        }
    }
}
