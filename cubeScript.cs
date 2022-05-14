using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        if(Input.GetKeyDown(KeyCode.C))
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        if(Input.GetKeyDown(KeyCode.R))
            gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}