using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaPuertas : MonoBehaviour
{
    public ControlPersonaje personaje;
    public bool jugadorCerca;
    public bool MisionCumplida;
    public GameObject panelInteraccion;
    public Text cajaRespuesta;
    
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                // Paso de piso 3 a la Salida
        if(Input.GetKey(KeyCode.F)
        && GameObject.FindWithTag("Salida"))
        {
            SceneManager.LoadScene("Completado");
        }
    }

    public void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            jugadorCerca = true;
            Debug.Log("jugador cerca");
            personaje.enabled = false;
            panelInteraccion.SetActive(true);
        }
    }
    public void OnTriggerStay(Collider coll)
    {
                //Paso del piso 1 al 2
        if(Input.GetKey(KeyCode.F)
        && GameObject.FindWithTag("Nivel2"))
        {
            SceneManager.LoadScene("Nivel02");
        }
        
                // Paso del piso 2 al 3 
        if(GameObject.FindWithTag("Nivel3") // Esto toma como condicion la caja de respuestas 
        && cajaRespuesta.text == "El hombre es enano"
        || cajaRespuesta.text == "Es enano")
        {
            SceneManager.LoadScene("Nivel03");
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if(coll.tag == "Player")
        {
            jugadorCerca = false;
            personaje.enabled = true;
            panelInteraccion.SetActive(false);
        }
    }

    public void NoRespuesta()
    {
        personaje.enabled = true;       
    }

}
