using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float rotationAcceleration;

    [SerializeField] bool angularDampingEnabled;
    [SerializeField] float angularDampingAmount;

    void OnValidate()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("left"))
        {
            rb.angularVelocity += rotationAcceleration * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            rb.angularVelocity -= rotationAcceleration * Time.deltaTime;
        }

        if (Mathf.Abs(rb.angularVelocity) > 100)
        {
            print("too fast!");
            rb.angularVelocity = 0;
        }

        if (angularDampingEnabled)
        {
            // angularDamping doesn't seem to exist... angularDrag seems to have the same funcionality
            rb.angularDrag = angularDampingAmount;
        }
    }
}
