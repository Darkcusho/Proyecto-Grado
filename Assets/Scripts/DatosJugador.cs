using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosJugador : MonoBehaviour
{   
    public InputField cajaNombre,cajaEdad;
    public string nombre,edad; 
    public Vector3 posicion;
    public object DatosJ;
    
    public void CapturarDatos()
    {
        nombre = cajaNombre.text;
        edad = cajaEdad.text;
        posicion = transform.position;
        DatosJ = new 
                    {
                        Nombre = nombre,
                        Edad = edad,
                        Posicion = posicion
                    };
    }    
}
