using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaPuertas : MonoBehaviour
{
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
    }
    void OnTriggerExit(Collider coll)
    {
        if(coll.tag == "Player")
        {
            jugadorCerca = false;
            panelInteraccion.SetActive(false);
        }
    }
}
