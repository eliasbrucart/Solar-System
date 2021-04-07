using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float speed;

    public Vector3 initialPos;

    public Transform cam;

    private bool follow;

    private Vector3 offset = new Vector3(0.0f, -15.0f, 60.0f);

    void Start()
    {
        transform.position = initialPos;
        follow = true;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        transform.position += direction * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.N))
        {
            follow = true;
        }
    }

    void LateUpdate()
    {
        if (follow == true)
        {
            cam.transform.position = transform.position - offset;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Color blend = other.gameObject.GetComponent<MeshRenderer>().material.color;
        blend.a = 0.5f;
        other.gameObject.GetComponent<MeshRenderer>().material.color = new Color(blend.r, blend.g, blend.b, blend.a);
    }

    public void OnTriggerExit(Collider other)
    {
        Color blend = other.gameObject.GetComponent<MeshRenderer>().material.color;
        blend.a = 1.0f;
        other.gameObject.GetComponent<MeshRenderer>().material.color = new Color(blend.r, blend.g, blend.b, blend.a);
    }
}
