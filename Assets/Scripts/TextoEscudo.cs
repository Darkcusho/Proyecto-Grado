using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoEscudo : MonoBehaviour
{
    public GameObject panelEscudo;
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
        panelEscudo.SetActive(true);
    }

    public void OnTriggerExit(Collider coll)
    {
        panelEscudo.SetActive(false);
    }
}
