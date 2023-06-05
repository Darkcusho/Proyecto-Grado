using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaNPC : MonoBehaviour
{
    public GameObject simboloMision;
    public ControlPersonaje jugador;
    public GameObject panelNPC;
    public GameObject panelNPC2;
    public GameObject panelNPCMision;
    public TextMeshProUGUI textoMision;
    public bool jugadorCerca;
    public bool aceptarMision;
    public GameObject[] objetivos;
    public int numDeObjetivos;
    public GameObject botonDeMision;

    public GameObject Libro,Lexico;

    void Start()
    {
        numDeObjetivos = objetivos.Length;
        textoMision.text = "Busca el libro y el Léxico perdidos"+
                        "\n Restantes: "+ numDeObjetivos;
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<ControlPersonaje>();
        simboloMision.SetActive(true);
        panelNPC.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && aceptarMision == false)
        {
            Vector3 posicionJugador = new Vector3(transform.position.x, jugador.gameObject.transform.position.y, transform.position.z);
            jugador.gameObject.transform.LookAt(posicionJugador);

            jugador.anim.SetFloat("VelX", 0);
            jugador.anim.SetFloat("VelY", 0);
            jugador.enabled = false;
            panelNPC.SetActive(false);
            panelNPC2.SetActive(true);
        }
    }
    
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            jugadorCerca = true;
            if (aceptarMision == false)
            {
                panelNPC.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if (coll.tag == "Player")
        {
            jugadorCerca = false;

            panelNPC.SetActive(false);
            panelNPC2.SetActive(false);
        }
    }

    public void No()
    {
        jugador.enabled = true;
        panelNPC2.SetActive(false);
        panelNPC.SetActive(true);
    }

    public void Si()
    {
        jugador.enabled = true;
        aceptarMision = true;
        for(int i = 0 ; i > objetivos.Length ; i++)
        {
            objetivos[i].SetActive(true);   
        }
        jugadorCerca = false;
        simboloMision.SetActive(false);
        panelNPC.SetActive(false);
        panelNPC2.SetActive(false);
        panelNPCMision.SetActive(true);
        Libro.SetActive(true);
        Lexico.SetActive(true);
    }
}
