using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPasos : MonoBehaviour
{   
    public AudioSource pasos;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // AUDIO PASOS
        if(Input.GetKeyDown(KeyCode.W))
        {
            pasos.Play();
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            pasos.Stop();
        }
        
        // AUDIO LIBROS
        /*
        if(Input.GetKey(KeyCode.R))
        {
            libro.Play();
        }
        else
        {
            libro.Stop();
        }

        // AUDIO PUERTAS
        if(Input.GetKeyDown(KeyCode.F)
        && GameObject.FindWithTag("Nivel2"))
        {
            puerta.Play();
        }
        */

    }
}
