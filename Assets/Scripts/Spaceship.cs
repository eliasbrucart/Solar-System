﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float speed;

    public Vector3 initialPos;
    void Start()
    {
        transform.position = initialPos;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        transform.position += direction * speed * Time.deltaTime;
    }
}