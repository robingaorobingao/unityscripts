using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private string doorOpen = "DoorOpen";
    private void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDoor.Play(doorOpen, 0, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
