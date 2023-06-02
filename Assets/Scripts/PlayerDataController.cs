using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;


public class PlayerDataController : MonoBehaviour
{
    private string connectionString;
    public DatosJugador Datos;
    public string Nombre,Edad,Pos;
    public Vector3 posJugador;

    private void Start()
    {
        // Establecer la cadena de conexión a la base de datos SQLite
        connectionString = "URI=file:" + Application.persistentDataPath + "/playerdata.db";

        // Crear la tabla si no existe
        CrearTablaJugadores();
    }
    private void CrearTablaJugadores()
    {
        // Abrir la conexión a la base de datos
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Crear una sentencia SQL para crear la tabla si no existe
            string createTableQuery = "CREATE TABLE IF NOT EXISTS TablaJugador (Nombre TEXT, Edad INTEGER, Posicion TEXT)";

            // Crear un comando SQL y ejecutar la consulta
            using (var command = new SqliteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Cerrar la conexión a la base de datos
            connection.Close();
        }
    }    
    public void TomarDatosJugador()
    {
        //Obtener los datos actuales del jugador
        /*
        Nombre = Datos.nombre;
        Edad = Datos.edad;
        posJugador = Datos.posicion;
        */
        // Guardamos los datos en la base de datos
        GuardarDatosJugador(Datos.nombre,Datos.edad,Datos.posicion);
    }
    public void GuardarDatosJugador(string Nombre, string Edad, Vector3 posJugador)
    {
        // Abrir la conexión a la base de datos
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Crear una sentencia SQL para insertar los datos del jugador
            string insertQuery = "INSERT INTO TablaJugador (Nombre, Edad, Posicion) VALUES (@Nombre, @Edad, @Posicion)";

            // Crear un comando SQL y establecer los parámetros
            using (var command = new SqliteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Edad", Edad);
                command.Parameters.AddWithValue("@Posicion", posJugador);

                // Ejecutar la consulta
                command.ExecuteNonQuery();
            }
            // Verifico(?)
            Debug.Log("Consulta Ejecutada"); 
            // Cerrar la conexión a la base de datos
            connection.Close();
        }
    }
    public void CargarDatosJugador()
    {
        // Abro conexión a la base de datos
        using(var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Sentencia SQL para obtener los datos guardados
            string selectQuery = "SELECT Nombre,Edad,Posicion FROM TablaJugador LIMIT 1";

            // Crear comando SQL para ejecutar consulta(y ejecutarla, obvio)
            using(var command = new SqliteCommand(selectQuery,connection))
            {
                using(var reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        Nombre = reader.GetString(0);
                        Edad = reader.GetString(1);
                        Pos = reader.GetString(2);
                    }
                }
            }
            // Cerrar conexión
            connection.Close();
        }
    }
}
