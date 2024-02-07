using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public bool isPaused;

    public KeyCode pauseButton;

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
            }
            else {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.GetComponent<Canvas> ().enabled = true;
        isPaused = true;

    }

    public void ResumeGame()
    {
        pauseMenu.GetComponent<Canvas> ().enabled = false;
        isPaused = false;
    }
}
