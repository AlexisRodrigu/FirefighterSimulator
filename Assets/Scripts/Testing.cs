using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    float speed = 15.0f;
    Rigidbody rb;
    void Start()
    {
      rb=   GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(speed*Time.deltaTime,0,0);
    }
}
