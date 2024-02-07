using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1)){
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector3(-17f, 2f, 79f);
            gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F2)){
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector3(-37f, 2f, -61f);
            gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F3)){
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector3(23f, 2f, 36f);
            gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F4)){
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector3(71f, 2f, -41f);
            gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F5)){
            gameObject.SetActive(false);
            gameObject.transform.position = new Vector3(72f, 2f, -64f);
            gameObject.SetActive(true);
        }

    }
}
