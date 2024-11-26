using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public List<GameObject> buttonThingies = new List<GameObject>();

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            buttonThingies[0].GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            buttonThingies[0].GetComponent<SpriteRenderer>().color = Color.white;
        }

        if (Input.GetButton("Fire2"))
        {
            buttonThingies[1].GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            buttonThingies[1].GetComponent<SpriteRenderer>().color = Color.white;
        }

        if (Input.GetButton("Fire3"))
        {
            buttonThingies[2].GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            buttonThingies[2].GetComponent<SpriteRenderer>().color = Color.white;
        }

        if (Input.GetButton("Jump"))
        {
            buttonThingies[3].GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            buttonThingies[3].GetComponent<SpriteRenderer>().color = Color.white;
        }

    }
}
