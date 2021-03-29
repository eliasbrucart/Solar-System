using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    public float speed = 5;
    public float radius = 2;
    public float angle = 0;

    public float rotateSpeed = 23.37f;

    public Vector3 v3;

    // Start is called before the first frame update
    void Start()
    {
        v3 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * speed * Time.deltaTime

        angle += speed * Time.deltaTime;

        v3.x = radius * Mathf.Cos(angle);
        v3.z = radius * Mathf.Sin(angle);

        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

        transform.position = v3;

    }
}
