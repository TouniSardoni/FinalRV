using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apariciones : MonoBehaviour
{
    public PlayerDetector player;
    public bool playerNear;
    public int OrdenAparicion;
    public GameObject Aparicion;
    public void Desaparecer() {Aparicion.SetActive(false); SonidoDesaparicion = true;}
    public void Aparecer() {Aparicion.SetActive(true);}
    public bool Visto;
    public AudioSource SonidoDesAparicion;
    public bool SonidoDesaparicion;

    // Start is called before the first frame update
    void Start()
    {
        Aparicion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OrdenAparicion <= player.OrdenPlayer && Visto == false) {
            Invoke("Aparecer", 0.3f);
            Visto = true;
            }

        if (playerNear == true && SonidoDesaparicion == false && Visto == true) {
            Invoke("Desaparecer", 0);
            SonidoDesAparicion.Play();
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
