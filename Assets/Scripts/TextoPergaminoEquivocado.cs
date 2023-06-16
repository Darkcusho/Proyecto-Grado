using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoPergaminoEquivocado : MonoBehaviour
{
    public GameObject panelAviso;
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
        if(coll.tag == "Player")
        {
            panelAviso.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider coll)
    {
        if(coll.tag == "Player")
        {
            panelAviso.SetActive(false);
        }
    }
}
