using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    // public AudioSource audioSource;
    // public GameObject camActive;
    // public GameObject playActive;
    // public GameObject canvasOn;
    public GameObject plant;
    // void Start()
    // {
    //     audioSource = GetComponent<AudioSource>();
    // }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("please work");
    //     audioSource.Play();
    //     foreach(GameObject go in GameObject.FindGameObjectWithTag("Player"));
    //     go.GetComponent<FirstPersonAIO>().enabled=false;
    //     audioSource.Play();
    //     camActive.SetActive(true);
    //     playActive.SetActive(false);
    //     canvasOn.SetActive(true);
    // }

    private void OnTriggerStay(Collider other)
    {
    // foreach(GameObject go in GameObject.FindGameObjectWithTag("Player"))
    // {
        // if(Input.GetKeyDown(KeyCode.F))
        // go.GetComponent<FirstPersonAIO>().enabled=false;
        // if(Input.GetKeyDown(KeyCode.U))
        // go.GetComponent<FirstPersonAIO>().enabled=true;
        if(Input.GetKeyDown(KeyCode.E))
        plant.SetActive(false);
    // }
    }
}