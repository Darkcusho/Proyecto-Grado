using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaPuertas : MonoBehaviour
{
    public bool jugadorCerca;
    public bool aceptarMision;
    public GameObject panelNPC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)
        && GameObject.FindWithTag("Nivel2"))
        {
            SceneManager.LoadScene("Nivel02");
        }
        if(Input.GetKeyDown(KeyCode.F)
        && GameObject.FindWithTag("Nivel3"))
        {
            SceneManager.LoadScene("Nivel03");
        }
        if(Input.GetKeyDown(KeyCode.F)
        && GameObject.FindWithTag("Salida"))
        {
            SceneManager.LoadScene("Completado");
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            jugadorCerca = true;
            panelNPC.SetActive(true);
        }
    }
}
