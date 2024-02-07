using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorDeNotas : MonoBehaviour
{
    public GameObject notaVisual;
    public bool nota;
    public GameObject UI;
    
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && nota == true)
        {
            notaVisual.SetActive(true);
            UI.SetActive(false);
        }
        if(Input.GetKeyUp(KeyCode.E) && nota == true)
        {
            notaVisual.SetActive(false);
            UI.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            nota = true;
            UI.SetActive(true);
        }
    
    }
     private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            nota = false;
            notaVisual.SetActive(false);
            UI.SetActive(false);
        }
    
    }


}
