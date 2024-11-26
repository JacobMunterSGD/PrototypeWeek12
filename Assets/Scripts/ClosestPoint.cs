using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestPoint1 : MonoBehaviour
{
    [SerializeField] GameObject cursor;
    [SerializeField] Rigidbody2D rb;

    private void OnValidate()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 currentClosestPoint = rb.ClosestPoint(cursor.transform.position);

        Debug.DrawLine(currentClosestPoint, cursor.transform.position, Color.red);

    }
}
