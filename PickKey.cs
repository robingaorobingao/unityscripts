using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public Component doorcolliderhere;
    public GameObject keygone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
        keygone.SetActive(false);
    }
}
