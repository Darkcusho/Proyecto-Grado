using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjetos : MonoBehaviour
{
    public LogicaNPC NPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "Player")
        {
            NPC.numDeObjetivos--;
            NPC.textoMision.text = "Busca el libro y el Léxico perdidos"+
                                "\n Restantes: "+ NPC.numDeObjetivos;
            if(NPC.numDeObjetivos <= 0)
            {
                NPC.textoMision.text = "Objetos recogidos";
                NPC.botonDeMision.SetActive(true);
            }
            transform.parent.gameObject.SetActive(false);
        }
    }
}
