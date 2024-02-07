using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedSecreta : MonoBehaviour
{
    public bool playerNear;
    public Animator anim;

    public bool Clave1;
    public bool Clave2;
    public bool Clave3;
    public bool Clave4;

    public void Correcta1() {
        Clave1 = true;
    }

    public void Correcta2() {
        Clave2 = true;
    }

    public void Correcta3() {
        Clave3 = true;
    }

    public void Correcta4() {
        Clave4 = true;
    }

    public void BajarPared() {
        anim.Play("ParedSecreta");
    }

    public AudioSource SonidoTeclas;
    public AudioSource SonidoPared;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) && playerNear && Clave1 == false) {
            Invoke("Correcta1", 0.1f);
            SonidoTeclas.Play();
        } else if ((
        Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2) ||
        Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3) ||
        Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4) ||
        Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5) ||
        Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6) ||
        Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7) ||
        Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8) ||
        Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9) ||
        Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)
        ) && playerNear && Clave1 == false)
        {
            SonidoTeclas.Play();
            Clave1 = false;
            Clave2 = false;
            Clave3 = false;
            Clave4 = false;
        }

        if ((Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) && playerNear && Clave1 == true && Clave2 == false) {
            Invoke("Correcta2", 0.1f);
            SonidoTeclas.Play();
        } else if ((
        Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1) ||
        Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2) ||
        Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3) ||
        Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4) ||
        Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5) ||
        Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6) ||
        Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7) ||
        Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8) ||
        Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)
        ) && playerNear && Clave1 == true && Clave2 == false)
        {
            SonidoTeclas.Play();
            Clave1 = false;
            Clave2 = false;
            Clave3 = false;
            Clave4 = false;
        }

        if ((Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) && playerNear && Clave2 == true && Clave3 == false) {
            Invoke("Correcta3", 0.1f);
            SonidoTeclas.Play();
        } else if ((
        Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1) ||
        Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2) ||
        Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3) ||
        Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4) ||
        Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5) ||
        Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6) ||
        Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7) ||
        Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9) ||
        Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)
        ) && playerNear && Clave2 == true && Clave3 == false)
        {
            SonidoTeclas.Play();
            Clave1 = false;
            Clave2 = false;
            Clave3 = false;
            Clave4 = false;
        }

        if ((Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) && playerNear && Clave3 == true && Clave4 == false) {
            Invoke("Correcta4", 0.1f);
            SonidoTeclas.Play();
            SonidoPared.Play();
        } else if ((
        Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1) ||
        Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2) ||
        Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3) ||
        Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4) ||
        Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5) ||
        Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6) ||
        Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7) ||
        Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8) ||
        Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)
        ) && playerNear && Clave3 == true && Clave4 == false)
        {
            SonidoTeclas.Play();
            Clave1 = false;
            Clave2 = false;
            Clave3 = false;
            Clave4 = false;
        }

        if (Clave4 == true) {
            Invoke("BajarPared", 0.5f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerDetector>()) playerNear = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerDetector>()) playerNear = false;
    }
}
