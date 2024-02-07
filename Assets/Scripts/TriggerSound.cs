using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{

    public AudioSource PlaySound;
    public bool played;
    
    void Start()
    {
        played = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(played)
        {

        }
        else if(!played)
        {
            PlaySound.Play();
            played = true;
        }
    }
    
}
