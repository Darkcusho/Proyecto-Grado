using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoDaga : MonoBehaviour
{   
    public GameObject panelDaga;
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
            panelDaga.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider coll)
    {
        if(coll.tag == "Player")
        {
            panelDaga.SetActive(false);
        }
    }
}
