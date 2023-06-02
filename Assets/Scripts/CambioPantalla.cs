using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioPantalla : MonoBehaviour
{
    SceneManager sceneManager;
    public InputField cajaEdad,cajaNombre;
    public int Edad = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Principal");
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
    public void MenuPausa()
    {
        SceneManager.LoadScene("MenuPausa");
    }
    public void Nivel01()
    {    
        //SceneManager.LoadScene("Nivel01");   
        if(cajaNombre.text != ""
        && cajaEdad.text != "")
        {
            Edad = int.Parse(cajaEdad.text);
            if(Edad >= 15)
            {
                SceneManager.LoadScene("Nivel01"); 
            }
            else
            {
                Debug.Log("Eres muy pequeño, andate a jugar pepa pig ctm!!");
            }
        }
        else
        {
            Debug.Log("Rellena los campos solicitados, Porfavor!");
        }
    }    
    public void Salir()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
