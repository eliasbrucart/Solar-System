using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using UnityEngine;

public class SolarSystemManager : MonoBehaviour
{
    public int amountPlanets = 0;
    public GameObject[] planets;

    void Start()
    {
        List<int> listNumbers = new List<int>();
        int random = 0;
        for(int i = 0; i < amountPlanets; i++)
        {
            do
            {
                random = UnityEngine.Random.Range(0, planets.Length);
            } while (listNumbers.Contains(random));
            listNumbers.Add(random);
            Instantiate(planets[listNumbers[i]]);
        }
    }

    void Update()
    {

    }
}
