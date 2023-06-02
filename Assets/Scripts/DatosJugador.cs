using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosJugador : MonoBehaviour
{   
    public string nombre,edad; 
    private CambioPantalla cajas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TomarDatos()
    {
        nombre = cajas.cajaNombre.text;
        edad = (cajas.cajaEdad.text).ToString();
    }
}
