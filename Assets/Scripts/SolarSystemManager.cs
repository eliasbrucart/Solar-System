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

        private float minIntensity = 0.2f;
        private float maxIntensity = 1.0f;

        public Light pointLight;
        private bool lightIntensity;
        private float randomIntensity;

        private int planetIndex = 0;
        private Vector3 offset = new Vector3(0.0f, -25.0f, 75.0f);

        private bool follow = false;

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
            randomIntensity = minIntensity;
            lightIntensity = false;
        }

        void Update()
        {
            //randomIntensity = Random.Range(0.0f, 10.0f);
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                planetIndex = 0;
                follow = true;
                Debug.Log("Tierra");
            }
            if (Input.GetKey(KeyCode.Alpha1))
            {
                planetIndex = 1;
                follow = true;
                Debug.Log("Jupiter");
            }
            if (Input.GetKey(KeyCode.Alpha2))
            {
                planetIndex = 2;
                follow = true;
                Debug.Log("Mars");
            }
            if (Input.GetKey(KeyCode.Alpha3))
            {
                planetIndex = 3;
                follow = true;
                Debug.Log("Mercury");
            }
            if (Input.GetKey(KeyCode.Alpha4))
            {
                planetIndex = 4;
                follow = true;
                Debug.Log("Neptune");
            }
            if (Input.GetKey(KeyCode.Alpha5))
            {
                planetIndex = 5;
                follow = true;
                Debug.Log("Pluton");
            }
            if (Input.GetKey(KeyCode.Alpha6))
            {
                planetIndex = 6;
                follow = true;
                Debug.Log("Saturn");
            }
            if (Input.GetKey(KeyCode.Alpha7))
            {
                planetIndex = 7;
                follow = true;
                Debug.Log("Uranus");
            }
            if (Input.GetKey(KeyCode.Alpha8))
            {
                planetIndex = 8;
                follow = true;
                Debug.Log("Venus");
            }
            if (Input.GetKey(KeyCode.N))
            {
                follow = false;
            }

            if (!lightIntensity)
                randomIntensity += Random.Range(minIntensity, maxIntensity) * Time.deltaTime;
            else
                randomIntensity -= Random.Range(minIntensity, maxIntensity) * Time.deltaTime;

            if (randomIntensity >= maxIntensity)
                lightIntensity = true;
            if(randomIntensity <= minIntensity)
                lightIntensity = false;

            pointLight.intensity = Mathf.Sin(randomIntensity);
            //float noise = Mathf.PerlinNoise(randomIntensity, Time.time);
            //pointLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
        }

        void LateUpdate()
        {
            if(follow == true)
            {
                cam.transform.position = planetsCreated[planetIndex].transform.position - offset;
            }
        }
    }
}
