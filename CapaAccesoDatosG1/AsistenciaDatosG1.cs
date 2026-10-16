using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatosG1
{
    public class AsistenciaDatosG1
    {
        // Buscar empleado por código de carnet
        public DataTable SubBuscarEmpleadoPorCodigoG1(string codigoCarnet)
        {
            DataTable dt = new DataTable();
            string query = "SELECT IdEmpleado, Nombres, Apellidos FROM Empleados WHERE CodigoCarnet = @codigo AND Activo = 1";

            using (SqlConnection conn = ConexionG1.SubObtenerConexionG1())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigoCarnet);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Verificar si ya tiene entrada hoy
        public bool SubYaTieneEntradaHoyG1(int idEmpleado)
        {
            string query = "SELECT COUNT(*) FROM RegistroAsistencia WHERE IdEmpleado = @id AND CAST(FechaHoraEntrada AS DATE) = CAST(GETDATE() AS DATE)";
            using (SqlConnection conn = ConexionG1.SubObtenerConexionG1())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        // Registrar entrada
        public bool SubRegistrarEntradaG1(int idEmpleado, DateTime fechaHora, string estado)
        {
            string query = @"INSERT INTO RegistroAsistencia (IdEmpleado, FechaHoraEntrada, Estado, HorasExtras) 
                             VALUES (@id, @fecha, @estado, 0.00)";
            using (SqlConnection conn = ConexionG1.SubObtenerConexionG1())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    cmd.Parameters.AddWithValue("@fecha", fechaHora);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Buscar registro pendiente de salida
        public DataTable SubBuscarRegistroPendienteG1(int idEmpleado)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT IdRegistro, FechaHoraEntrada FROM RegistroAsistencia 
                             WHERE IdEmpleado = @id AND CAST(FechaHoraEntrada AS DATE) = CAST(GETDATE() AS DATE) 
                             AND FechaHoraSalida IS NULL";
            using (SqlConnection conn = ConexionG1.SubObtenerConexionG1())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Registrar salida
        public bool SubRegistrarSalidaG1(int idRegistro, DateTime fechaHora, decimal horasExtras)
        {
            string query = "UPDATE RegistroAsistencia SET FechaHoraSalida = @fecha, HorasExtras = @extras WHERE IdRegistro = @idRegistro";
            using (SqlConnection conn = ConexionG1.SubObtenerConexionG1())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha", fechaHora);
                    cmd.Parameters.AddWithValue("@extras", horasExtras);
                    cmd.Parameters.AddWithValue("@idRegistro", idRegistro);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Cargar reporte por fechas
        public DataTable SubCargarReporteG1(DateTime desde, DateTime hasta)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT 
                    R.IdRegistro,
                    E.CodigoCarnet,
                    E.Nombres + ' ' + E.Apellidos AS Empleado,
                    R.FechaHoraEntrada,
                    R.FechaHoraSalida,
                    R.Estado,
                    R.HorasExtras
                FROM RegistroAsistencia R
                INNER JOIN Empleados E ON R.IdEmpleado = E.IdEmpleado
                WHERE CAST(R.FechaHoraEntrada AS DATE) BETWEEN @desde AND @hasta
                ORDER BY R.FechaHoraEntrada DESC";
            using (SqlConnection conn = ConexionG1.SubObtenerConexionG1())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}