using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;


public class PlayerDataController : MonoBehaviour
{
    
    public DatosJugador Datos;
    public string Nombre,Pos;
    public int Edad;
    public Vector3 posJugador;

    private void Start()
    {
        // Establecer la cadena de conexión a la base de datos SQLite
        

        // Crear la tabla si no existe
        CrearTablaJugadores();
    }
    private void CrearTablaJugadores()
    {
        // Abrir la conexión a la base de datos
       
    }    
    public void TomarDatosJugador()
    {
        //Obtener los datos actuales del jugador
        Nombre = DatosJugador.nombre;
        Edad = DatosJugador.edad;
        posJugador = DatosJugador.posicion;
        // Guardamos los datos en la base de datos
        GuardarDatosJugador(Nombre,Edad,posJugador);
       
    }
    public void GuardarDatosJugador(string Nombre, int Edad, Vector3 posJugador)
    { 
        try{
            
        MisDatos mis_datos = new MisDatos();
        mis_datos.age=Edad;
        mis_datos.name=Nombre;
        mis_datos.position= posJugador.ToString();
        mis_datos.Save();
        }
        catch(Exception ex){
            Debug.Log(ex);
        }
    }
    public void CargarDatosJugador()
    {
        // Abro conexión a la base de datos      
         MisDatos mis_datos = new MisDatos();
         mis_datos.Read();
         //aqui vvienen llenos los datos
         Debug.Log(mis_datos.name);
         Debug.Log(mis_datos.age);
         Debug.Log(mis_datos.position);
         //posJugador = mis_datos.position;
    }
}
