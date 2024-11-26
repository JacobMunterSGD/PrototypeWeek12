using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllertest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 controllerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Debug.DrawLine(Vector2.zero, controllerInput);
        //print(controllerInput);

        transform.position = controllerInput;
    }
}
