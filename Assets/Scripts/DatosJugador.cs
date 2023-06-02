using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosJugador : MonoBehaviour
{   
    public InputField cajaNombre,cajaEdad;
    public string nombre,edad; 
    public Vector3 posicion;

    private void Start()
    {
        nombre = cajaNombre.text;
        edad = cajaEdad.text.ToString();
        posicion = transform.position;
    }
}
