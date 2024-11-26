using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wedge : MonoBehaviour
{
    SpriteRenderer sr;

    private void OnValidate()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sr.color = Color.blue;
        print("working");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        sr.color = Color.white;
    }

    private void Update()
    {
        if (sr.color == Color.blue && Input.GetButtonDown("Fire1"))
        {
            sr.color = Color.green;
        }
    }

}
