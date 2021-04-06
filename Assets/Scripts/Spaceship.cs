using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float speed;

    public Vector3 initialPos;

    public Transform cam;

    private Vector3 offset = new Vector3(0.0f, -10.0f, 60.0f);

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

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.N))
        {
            cam.transform.position = transform.position - offset;
        }
    }
}
