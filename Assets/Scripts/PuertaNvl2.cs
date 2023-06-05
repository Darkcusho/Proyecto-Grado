using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuertaNvl2 : MonoBehaviour
{
    public GameObject panelInteraccion;
    public Text cajaRespuesta;
    public ControlPersonaje personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider coll)
    {
                if(coll.tag == "Player")
        {
            panelInteraccion.SetActive(true);
            personaje.enabled = false;
        }
    }
    public void OnTriggerStay(Collider coll)
    {
                // Paso del piso 2 al 3 
        if(GameObject.FindWithTag("Nivel3") // Esto toma como condicion la caja de respuestas 
        && cajaRespuesta.text == "El hombre es enano"
        || cajaRespuesta.text == "Es enano")
        {
            SceneManager.LoadScene("Nivel03");
        }
    }

    public void NoRespuesta()
    {
        personaje.enabled = true; 
        panelInteraccion.SetActive(false);      
    }
}
