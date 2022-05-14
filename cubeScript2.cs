using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript2 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        if(Input.GetKeyDown(KeyCode.G))
            gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}