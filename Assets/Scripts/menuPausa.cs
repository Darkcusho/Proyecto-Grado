using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuPausa : MonoBehaviour
{
    private bool MenuActivo;
    public GameObject panelPausa;
    public ControlPersonaje pj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            panelPausa.SetActive(true);
        }
    }

    public void Salir()
    {
        SceneManager.LoadScene("Principal");
    }
}
