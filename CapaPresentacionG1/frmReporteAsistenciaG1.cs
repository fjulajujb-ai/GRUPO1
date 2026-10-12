using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaAccesoDatosG1;

namespace CapaPresentacionG1
{
    public partial class frmReporteAsistenciaG1 : Form
    {
        public frmReporteAsistenciaG1()
        {
            InitializeComponent();
            SubCargarReporteG1();
        }

        // ==========================================
        // EVENTO: REGISTRAR INGRESO
        // ==========================================
        private void btnRegistrarIngresoG1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoEmpleadoG1.Text))
            {
                MessageBox.Show("Por favor, ingrese el código de carnet.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigoEmpleadoG1.Text.Trim();
            DateTime ahora = DateTime.Now;

            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();

                    string queryBuscar = "SELECT IdEmpleado, Nombres, Apellidos FROM Empleados WHERE CodigoCarnet = @codigo AND Activo = 1";
                    SqlCommand cmdBuscar = new SqlCommand(queryBuscar, conexion);
                    cmdBuscar.Parameters.AddWithValue("@codigo", codigo);

                    SqlDataReader reader = cmdBuscar.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Empleado no encontrado o inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                        return;
                    }

                    int idEmpleado = Convert.ToInt32(reader["IdEmpleado"]);
                    string nombreCompleto = reader["Nombres"].ToString() + " " + reader["Apellidos"].ToString();
                    reader.Close();

                    lblNombreEmpleadoG1.Text = "Empleado: " + nombreCompleto;

                    string queryVerificar = "SELECT COUNT(*) FROM RegistroAsistencia WHERE IdEmpleado = @id AND CAST(FechaHoraEntrada AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexion);
                    cmdVerificar.Parameters.AddWithValue("@id", idEmpleado);

                    int existe = (int)cmdVerificar.ExecuteScalar();
                    if (existe > 0)
                    {
                        MessageBox.Show("Este empleado ya registró su ingreso hoy.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    TimeSpan horaLimite = new TimeSpan(8, 10, 0);
                    string estado = "Presente";
                    if (ahora.TimeOfDay > horaLimite)
                    {
                        estado = "Tarde";
                    }

                    string queryInsertar = "INSERT INTO RegistroAsistencia (IdEmpleado, FechaHoraEntrada, Estado, HorasExtras) VALUES (@id, @fecha, @estado, 0.00)";
                    SqlCommand cmdInsertar = new SqlCommand(queryInsertar, conexion);
                    cmdInsertar.Parameters.AddWithValue("@id", idEmpleado);
                    cmdInsertar.Parameters.AddWithValue("@fecha", ahora);
                    cmdInsertar.Parameters.AddWithValue("@estado", estado);
                    cmdInsertar.ExecuteNonQuery();

                    MessageBox.Show($"Ingreso registrado para {nombreCompleto} a las {ahora:HH:mm:ss}. Estado: {estado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoEmpleadoG1.Clear();
                    txtCodigoEmpleadoG1.Focus();
                    SubCargarReporteG1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // EVENTO: REGISTRAR SALIDA
        // ==========================================
        private void btnRegistrarSalidaG1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoEmpleadoG1.Text))
            {
                MessageBox.Show("Por favor, ingrese el código de carnet.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigoEmpleadoG1.Text.Trim();
            DateTime ahora = DateTime.Now;

            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();

                    string queryBuscar = "SELECT IdEmpleado, Nombres, Apellidos FROM Empleados WHERE CodigoCarnet = @codigo AND Activo = 1";
                    SqlCommand cmdBuscar = new SqlCommand(queryBuscar, conexion);
                    cmdBuscar.Parameters.AddWithValue("@codigo", codigo);

                    SqlDataReader reader = cmdBuscar.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Empleado no encontrado o inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                        return;
                    }

                    int idEmpleado = Convert.ToInt32(reader["IdEmpleado"]);
                    string nombreCompleto = reader["Nombres"].ToString() + " " + reader["Apellidos"].ToString();
                    reader.Close();

                    lblNombreEmpleadoG1.Text = "Empleado: " + nombreCompleto;

                    string queryBuscarRegistro = "SELECT IdRegistro, FechaHoraEntrada FROM RegistroAsistencia WHERE IdEmpleado = @id AND CAST(FechaHoraEntrada AS DATE) = CAST(GETDATE() AS DATE) AND FechaHoraSalida IS NULL";
                    SqlCommand cmdBuscarRegistro = new SqlCommand(queryBuscarRegistro, conexion);
                    cmdBuscarRegistro.Parameters.AddWithValue("@id", idEmpleado);

                    SqlDataReader readerRegistro = cmdBuscarRegistro.ExecuteReader();

                    if (!readerRegistro.Read())
                    {
                        MessageBox.Show("No se encontró un ingreso pendiente de salida para hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        readerRegistro.Close();
                        return;
                    }

                    int idRegistro = Convert.ToInt32(readerRegistro["IdRegistro"]);
                    readerRegistro.Close();

                    TimeSpan horaSalidaOficial = new TimeSpan(17, 0, 0);
                    decimal horasExtras = 0;
                    if (ahora.TimeOfDay > horaSalidaOficial)
                    {
                        horasExtras = (decimal)(ahora.TimeOfDay - horaSalidaOficial).TotalHours;
                    }

                    string queryActualizar = "UPDATE RegistroAsistencia SET FechaHoraSalida = @fecha, HorasExtras = @extras WHERE IdRegistro = @idRegistro";
                    SqlCommand cmdActualizar = new SqlCommand(queryActualizar, conexion);
                    cmdActualizar.Parameters.AddWithValue("@fecha", ahora);
                    cmdActualizar.Parameters.AddWithValue("@extras", horasExtras);
                    cmdActualizar.Parameters.AddWithValue("@idRegistro", idRegistro);
                    cmdActualizar.ExecuteNonQuery();

                    MessageBox.Show($"Salida registrada para {nombreCompleto} a las {ahora:HH:mm:ss}. Horas extras: {horasExtras:F2}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoEmpleadoG1.Clear();
                    txtCodigoEmpleadoG1.Focus();
                    SubCargarReporteG1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // EVENTO: BUSCAR REPORTE
        // ==========================================
        private void btnBuscarG1_Click(object sender, EventArgs e)
        {
            SubCargarReporteG1();
        }

        // ==========================================
        // MÉTODO: CARGAR REPORTE
        // ==========================================
        private void SubCargarReporteG1()
        {
            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();

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

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@desde", dtpDesdeG1.Value.Date);
                    cmd.Parameters.AddWithValue("@hasta", dtpHastaG1.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dgvReporteAsistenciaG1.DataSource = dt;

                    if (dgvReporteAsistenciaG1.Columns.Count > 0)
                    {
                        dgvReporteAsistenciaG1.Columns["IdRegistro"].Visible = false;
                        dgvReporteAsistenciaG1.Columns["CodigoCarnet"].HeaderText = "Código";
                        dgvReporteAsistenciaG1.Columns["Empleado"].HeaderText = "Empleado";
                        dgvReporteAsistenciaG1.Columns["FechaHoraEntrada"].HeaderText = "Entrada";
                        dgvReporteAsistenciaG1.Columns["FechaHoraEntrada"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        dgvReporteAsistenciaG1.Columns["FechaHoraSalida"].HeaderText = "Salida";
                        dgvReporteAsistenciaG1.Columns["FechaHoraSalida"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                        dgvReporteAsistenciaG1.Columns["Estado"].HeaderText = "Estado";
                        dgvReporteAsistenciaG1.Columns["HorasExtras"].HeaderText = "H. Extras";
                        dgvReporteAsistenciaG1.Columns["HorasExtras"].DefaultCellStyle.Format = "N2";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}