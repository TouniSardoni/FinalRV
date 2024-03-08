using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{

    public int OrdenPlayer;
    public GameObject Salida;
    public AudioSource SalidaSonido;
    public void SalidaS() {SalidaSonido.Play();}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OrdenPlayer == 5) {
        Salida.SetActive(true);
        Invoke("SalidaS", 1.25f);
        OrdenPlayer = 6;
        }
    }
}
