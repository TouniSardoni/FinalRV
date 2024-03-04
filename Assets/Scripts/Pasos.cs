using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasos : MonoBehaviour
{

    public AudioSource footstepsSound;
    public bool caminando;


    void Start()
    {
        //footsteps.SoundSetActive(true);
        //sprintSound.Stop();
    }

    void Update()

    {

        if(Input.GetKeyDown(KeyCode.W))
        {
            caminando = true;

            //sprintSound.Play();

        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            caminando = true;

            //sprintSound.Play();

        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            caminando = true;

            //sprintSound.Play();

        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            caminando = true;

            //sprintSound.Play();

        }



        if (Input.GetKeyUp(KeyCode.W)) {

        caminando = false;

        //sprintSound.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A)) {

        caminando = false;

        //sprintSound.Stop();
        }
        if (Input.GetKeyUp(KeyCode.S)) {

        caminando = false;

        //sprintSound.Stop();
        }
        if (Input.GetKeyUp(KeyCode.D)) {

        caminando = false;

        //sprintSound.Stop();
        }

        if (caminando == true) {

            footstepsSound.Play();

        } else if (caminando == false) {

            footstepsSound.Stop();
        }

    }
}
