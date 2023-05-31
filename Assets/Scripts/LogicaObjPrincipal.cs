using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicaObjPrincipal : MonoBehaviour
{
    public GameObject panelMision;
    public int numDeObjetivos;
    public TextMeshProUGUI textoMision;
    public GameObject botonTerminado;
    // Start is called before the first frame update
    void Start()
    {
        panelMision.SetActive(true);
        numDeObjetivos = GameObject.FindGameObjectsWithTag("PergaminoFinal").Length;
        textoMision.text = "Consigue el pergamino";  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "PergaminoFinal")
        {
            Destroy(coll.transform.parent.gameObject);
            numDeObjetivos--;
            textoMision.text = "Consigue el pergamino";
            if(numDeObjetivos == 0)
            {
                textoMision.text = "Conseguido, Ahora larguemonos de aqui!";
                botonTerminado.SetActive(true);
            }
        }
    }
}
