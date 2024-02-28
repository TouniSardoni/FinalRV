using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar : MonoBehaviour
{
    public bool playerNear;
    public KeyCode useKey;
    public Animator anim;
    public int OrdenPalanca;
    public int PalancaSiguiente;
    public PlayerDetector player;
    public AudioSource SonidoActivar;
    public AudioSource SonidoError;
    public void SonidoP() {SonidoActivar.Play();}
    bool Reproduciendo;
    public void DesbloquearPalanca() {Reproduciendo = false;}
    public AudioSource Chispas;
    public void PararChispas() {Chispas.Stop(); ParticulasChispas.Stop(); LucesAbajo.SetActive(true); LucesArriba.SetActive(false);}
    public GameObject UI;
    public GameObject LucesArriba;
    public GameObject LucesAbajo;
    public ParticleSystem ParticulasChispas;

    // Start is called before the first frame update
    void Start()
    {
        Chispas = GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();
        UI.SetActive(false);
        LucesAbajo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(useKey) && playerNear && OrdenPalanca == player.OrdenPlayer) {
            ActivateLever();
            }

        else if (Input.GetKeyDown(useKey) && playerNear && OrdenPalanca != player.OrdenPlayer && Reproduciendo == false) {
            WrongLever();
            }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerDetector>()) playerNear = true;
        UI.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerDetector>()) playerNear = false;
        UI.SetActive(false);
    }

    void ActivateLever()
    {
        anim.Play("Activar");
        player.OrdenPlayer = PalancaSiguiente;
        Invoke("SonidoP", 0.1f);
        Invoke("PararChispas", 0.75f);
        Reproduciendo = true;
    }

    void WrongLever()
    {
        anim.Play("ActivarError");
        SonidoError.Play();
        Reproduciendo = true;
        Invoke("DesbloquearPalanca", 3);
    }


}
