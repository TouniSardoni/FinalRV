using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    bool playerNear;
    public KeyCode useKey;
    public Animator anim;
    public GameObject jugador;
    public AudioSource SonidoPuertas;
    public GameObject UI;
    public bool Abierta;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(useKey) && playerNear) OpenDoor();
        if (playerNear) Debug.Log("jugador cerca");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerDetector>()) playerNear = true;
        if (Abierta == false){
            UI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerDetector>()) playerNear = false;
        UI.SetActive(false);
    }

    void OpenDoor()
    {
        anim.Play("puertaanimacion");
        SonidoPuertas.Play();
        UI.SetActive(false);
        Abierta = true;
    }
}
