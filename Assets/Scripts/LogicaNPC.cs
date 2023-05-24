using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaNPC : MonoBehaviour
{
    public GameObject simboloMision;
    private ControlPersonaje jugador;
    public GameObject panel1NPC;
    public GameObject panel1NPC2;
    public GameObject panel1NPCMision;
    public TextMeshProUGUI textoMision;
    private bool jugadorCerca;
    private bool aceptarMision;
    public GameObject[] objetivos;

    void Start()
    {
        textoMision.text = GetTextoMision(objetivos.Length);
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<ControlPersonaje>();
        simboloMision.SetActive(true);
        panel1NPC.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && aceptarMision)
        {
            Vector3 posicionJugador = new Vector3(transform.position.x, jugador.gameObject.transform.position.y, transform.position.z);
            jugador.gameObject.transform.LookAt(posicionJugador);

            jugador.anim.SetFloat("VelX", 0);
            jugador.anim.SetFloat("VelY", 0);
            jugador.enabled = false;
            panel1NPC.SetActive(false);
            panel1NPC2.SetActive(true);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            jugadorCerca = true;
            if (!aceptarMision)
            {
                panel1NPC.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            jugadorCerca = false;

            panel1NPC.SetActive(false);
            panel1NPC2.SetActive(false);
        }
    }

    private void No()
    {
        jugador.enabled = true;

        panel1NPC2.SetActive(false);

        panel1NPC.SetActive(true);
    }

    public void Si()
    {
        jugador.enabled = true;
        aceptarMision = true;
        foreach (GameObject objetivo in objetivos)
        {
            objetivo.SetActive(true);   
        }
        jugadorCerca = false;
        simboloMision.SetActive(false);
        panel1NPC.SetActive(false);
        panel1NPC2.SetActive(false);
        panel1NPCMision.SetActive(true);
    }

    private string GetTextoMision(int numObjetivos)
    {
        return $"Encuentra el brazalete, la llave y el libro del saber\nItems faltantes: {numObjetivos}";
    }
}
