using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caerse : MonoBehaviour
{
    
    public bool playerNear;
    public GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerNear == true){
            jugador.SetActive(false);
            jugador.transform.position = new Vector3(23f, 2f, 13f);
            jugador.SetActive(true);
            playerNear = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerDetector>()) playerNear = true;
    }
}
