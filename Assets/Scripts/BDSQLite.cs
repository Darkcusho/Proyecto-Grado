using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class BDSQLite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Creacion Base de Datos
        string connection = "URI=file:" + Application.persistentDataPath + "/" + "BDJuego";
        
        // Abrir conexion
        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open(); 


        //Crear tabla
        IDbCommand dbcmd;
        
        dbcmd = dbcon.CreateCommand();
        string q_createTable =
            "CREATE TABLE Tabla1 (id INTEGER PRIMARY KEY, val INTEGER)";

        dbcmd.CommandText = q_createTable;
        dbcmd.ExecuteReader();

        // Insertar datos en tabla
        IDbCommand cmnd = dbcon.CreateCommand();
        cmnd.CommandText = "INSERT INTO Tabla1 (id,val) VALUES (0,5)";
        cmnd.ExecuteNonQuery();

        // Leer y mostrar valores en tabla
        IDbCommand cmnd_read = dbcon.CreateCommand();
        IDataReader reader;
        string query ="SELECT * FROM Tabla1";
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader();
        while (reader.Read())
        {
            Debug.Log("id: " + reader[0].ToString());
            Debug.Log("val: " + reader[1].ToString());
        }
        
        // Cierre conexion
        dbcon.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
