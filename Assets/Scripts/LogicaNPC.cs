using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaNPC : MonoBehaviour
{
    public GameObject simboloMision;
    public ControlPersonaje jugador;
    public GameObject panel1NPC;
    public GameObject panel1NPC2;
    public GameObject panel1NPCMision;
    public TextMeshProUGUI textoMision;
    public bool jugadorCerca;
    public bool aceptarMision;
    public GameObject[] objetivos;
    public int numDeObjetivos;
    public GameObject botonDeMision;
    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivos = objetivos.Length;
        textoMision.text = "Encuentra el brazalete, la llave y el libro del saber" +
                           "\n Items faltantes: " + numDeObjetivos;
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<ControlPersonaje>();
        simboloMision.SetActive(true);
        panel1NPC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&& aceptarMision)
        {
            Vector3 posicionJugador = new Vector3(transform.position.x, jugador.gameObject.transform.position.y, transform.position.z);
            jugador.gameObject.transform.LookAt(posicionJugador);

            
        }
    }
}
