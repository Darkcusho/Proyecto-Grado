using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaObjetivos : MonoBehaviour
{   
    private int numDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonDeMision;

    void Start()
    {
        numDeObjetivos = GameObject.FindGameObjectsWithTag("Objetivo").Length;
        textoMision.text = GetTextoMision(numDeObjetivos);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Collider>() != null && col.gameObject.tag == "Objetivo")
        {
            Destroy(col.transform.parent.gameObject);
            numDeObjetivos--;
            textoMision.text = GetTextoMision(numDeObjetivos);
            if (numDeObjetivos <= 0)
            {
                textoMision.text = "ITEMS RECOLECTADOS";
                botonDeMision.SetActive(true);
            }
        }
    }

    private string GetTextoMision(int numObjetivos)
    {
        return $"Encuentra el brazalete, la llave y el libro del saber\nItems faltantes: {numObjetivos}";
    }
}
