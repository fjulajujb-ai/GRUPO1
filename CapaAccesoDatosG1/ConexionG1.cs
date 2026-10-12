using System.Data.SqlClient;

namespace CapaAccesoDatosG1
{
    public class ConexionG1
    {
        // Variable Global (g), tipo String (Str), nombre + G1
        public static string gStrCadenaConexionG1 = @"Server=localhost\SQLEXPRESS;Database=ControlAsistenciaDB;Trusted_Connection=True;";

        // Método para obtener la conexión (Sub + nombre + G1)
        public static SqlConnection SubObtenerConexionG1()
        {
            return new SqlConnection(gStrCadenaConexionG1);
        }
    }
}