using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionesVarias : MonoBehaviour
{   
    public Collider coll;
    public GameObject panelTexto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coll.tag == "Letura")
        {
            panelTexto.SetActive(true);
        }  
    }
}


