using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;

public class PlayerDataController : MonoBehaviour
{
    private string connectionString;
    public CambioPantalla Datos;
    public string Nombre,Edad,Pos;
    public Vector3 posJugador;

    private void Start()
    {
        // Establecer la cadena de conexión a la base de datos SQLite
        connectionString = "URI=file:" + Application.persistentDataPath + "/playerdata.db";

        // Crear la tabla si no existe
        CreatePlayerDataTable();
    }
    public void AddPlayerData(string Nombre, int Edad, string Posicion)
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
                command.Parameters.AddWithValue("@Posicion", Posicion);

                // Ejecutar la consulta
                command.ExecuteNonQuery();
            }

            // Cerrar la conexión a la base de datos
            connection.Close();
        }
    }
    private void CreatePlayerDataTable()
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
}
