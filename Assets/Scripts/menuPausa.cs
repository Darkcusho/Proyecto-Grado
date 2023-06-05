using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuPausa : MonoBehaviour
{
    private bool MenuActivo;
    public GameObject panelPausa;
    public ControlPersonaje pj;
    private bool pausado = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausado)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }
    }
    
    void Pausar()
    {
        panelPausa.SetActive(true);
        Time.timeScale = 0f; // Pausa mediante escala de tiempo.
        pausado = true;
        Debug.Log("Juego Pausado");// Pa asegurarse.
    }
    void Reanudar()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1f; //Reanuda la escala de tiempo
        pausado = false;
        Debug.Log("Juego Reanudado");// Lo mismo.
    }
    
    public void Salir()
    {
        SceneManager.LoadScene("Principal");
    }
}
