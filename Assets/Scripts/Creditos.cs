using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{

    public void VolverMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke ("VolverMenu", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
