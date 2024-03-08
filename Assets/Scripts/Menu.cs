using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void EmpezarNivel(string NombreNivel)
    {
        SceneManager.LoadScene("PrimerNivel");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("aca se cierra el juego");
    }
}
