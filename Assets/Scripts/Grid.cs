using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{

    float cooldown = 0;
    float cooldownStart = 0.2f;
    public float moveBy;

    void OnValidate()
    {
        
    }
    void Update()
    {
        Vector2 controllerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 DirectionOutput = DirectionPointing(controllerInput);
        if (cooldown <= 0)
        {
            transform.position += new Vector3(DirectionOutput.x, DirectionOutput.y, 0) * moveBy;
            cooldown = cooldownStart;
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
    Vector2 DirectionPointing(Vector2 input)
    {
        if (Mathf.Abs(input.x) < 0.1 && (Mathf.Abs(input.y) < 0.1))
        {
            return Vector2.zero;
        }

        if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
        {
            if (input.x > 0)
            {
                return Vector2.right;
            }
            if (input.x < 0)
            {
                return Vector2.left;
            }
        }
        else
        {
            if (input.y > 0)
            {
                return Vector2.up;
            }
            if (input.y < 0)
            {
                return Vector2.down;
            }
        }

        return Vector2.zero;
    }
}
