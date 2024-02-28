using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public bool isPaused;

    public KeyCode pauseButton;

    public GameObject Estatica;

    public AudioSource SonidoAbrir;

    public AudioSource SonidoCerrar;

    public void Cerrar () {
        Estatica.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pauseButton)) 
        {
            if(isPaused) 
            {
                ResumeGame();
                SonidoCerrar.Play();
            }
            else {
                SonidoAbrir.Play();
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.GetComponent<Canvas> ().enabled = true;
        isPaused = true;
        Estatica.SetActive(true);

    }

    public void ResumeGame()
    {
        pauseMenu.GetComponent<Canvas> ().enabled = false;
        isPaused = false;
        Estatica.SetActive(false);
        Estatica.SetActive(true);
        Invoke("Cerrar", 0.1f);
    }
}
