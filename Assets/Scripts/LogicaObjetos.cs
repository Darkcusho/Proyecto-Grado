using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaObjetos : MonoBehaviour
{   
    public int numDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonDeMision;
    // Start is called before the first frame update
    void Start()
    {
        numDeObjetivos = GameObject.FindGameObjectsWithTag("Objetivo").Length;
        textoMision.text = "Encuentra el brazalete, la llave y el libro del saber" +
                           "\n Items faltantes: " + numDeObjetivos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Objetivo")
        {
            Destroy(col.transform.parent.gameObject);
            numDeObjetivos--;
            textoMision.text = "Encuentra el brazalete, la llave y el libro del saber" +
                               "\n Items faltantes: " + numDeObjetivos;
            if (numDeObjetivos <=0)
            {
                textoMision.text = "ITEMS RECOLECTADOS";
                botonDeMision.SetActive(true);
            }
        }
    }
}
