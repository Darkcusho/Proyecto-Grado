using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class MisDatos
{
    private string connectionString;
    public string position;
    public string name;
    public int age;

    public MisDatos()
    {
        connectionString = "URI=file:playerdata.db";
        position = DatosJugador.posicion.ToString();
        name = DatosJugador.nombre;
        age = DatosJugador.edad;
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Crear una sentencia SQL para crear la tabla si no existe
            string createTableQuery = "CREATE TABLE IF NOT EXISTS TablaPartidas (Id integer PRIMARY KEY autoincrement, Nombre TEXT, Edad INTEGER, Posicion TEXT)";

            // Crear un comando SQL y ejecutar la consulta
            using (var command = new SqliteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Cerrar la conexión a la base de datos
            connection.Close();
        }
    }

    public void Save()
    {
        // Abrir la conexión a la base de datos
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Crear una sentencia SQL para insertar los datos del jugador
            string insertQuery = "INSERT INTO TablaPartidas (Nombre, Edad, Posicion) VALUES (@Nombre, @Edad, @Posicion)";

            // Crear un comando SQL y establecer los parámetros
            using (var command = new SqliteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Nombre", name);
                command.Parameters.AddWithValue("@Edad", age);
                command.Parameters.AddWithValue("@Posicion", position);

                // Ejecutar la consulta
                command.ExecuteNonQuery();
            }
            // Verifico (?)
            Debug.Log("Consulta Ejecutada"); 
            // Cerrar la conexión a la base de datos
            connection.Close();
        }
    }
    public void Read()
    {   
        // Abro conexión a la base de datos
        using(var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Sentencia SQL para obtener los datos guardados
            string selectQuery = "SELECT Nombre,Edad,Posicion FROM TablaPartidas where Nombre = @Nombre order by id desc limit 1";

            // Crear comando SQL para ejecutar consulta(y ejecutarla, obvio)
            using(var command = new SqliteCommand(selectQuery,connection))
            {
                command.Parameters.AddWithValue("@Nombre", name);
                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        name = reader.GetString(0);
                        age = reader.GetInt32(1);
                        position = reader.GetString(2);
                    }
                }
            }
            // Cerrar conexión
            connection.Close();
        }
    }
}
