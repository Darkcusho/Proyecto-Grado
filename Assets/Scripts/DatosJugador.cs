using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosJugador : MonoBehaviour
{   
    public InputField cajaNombre,cajaEdad;
    public static string nombre;
    public static int edad; 
    public static Vector3 posicion;
    
    public void CapturarDatos()
    {
        nombre = cajaNombre.text;
        edad = int.Parse(cajaEdad.text);
        posicion = transform.position;
    }    
    public void Awake(){
        DontDestroyOnLoad(this);
    }
}
