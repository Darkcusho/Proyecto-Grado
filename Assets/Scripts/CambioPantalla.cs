using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioPantalla : MonoBehaviour
{
    SceneManager sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuCreacion()
    {
        SceneManager.LoadScene("MenuCreacionn");
    }

    public void MenuOpciones()
    {
        SceneManager.LoadScene("MenuOpciones");
    }

    public void MenuCargar()
    {
        SceneManager.LoadScene("MenuCargar");
    }
}
