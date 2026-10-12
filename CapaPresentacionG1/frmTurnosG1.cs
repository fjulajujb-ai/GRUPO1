using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaAccesoDatosG1;

namespace CapaPresentacionG1
{
    public partial class frmTurnosG1 : Form
    {
        public frmTurnosG1()
        {
            InitializeComponent();
            SubCargarTurnosG1();
        }

        // ==========================================
        // EVENTO: GUARDAR NUEVO TURNO
        // ==========================================
        private void btnGuardarTurnoG1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTurnoG1.Text))
            {
                MessageBox.Show("Ingrese el nombre del turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEntradaG1.Text) || string.IsNullOrWhiteSpace(txtSalidaG1.Text))
            {
                MessageBox.Show("Ingrese la hora de entrada y salida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();

                    string query = @"INSERT INTO Turnos (NombreTurno, HoraEntrada, HoraSalida, ToleranciaMinutos) 
                                     VALUES (@nombre, @entrada, @salida, @tolerancia)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreTurnoG1.Text.Trim());
                    cmd.Parameters.AddWithValue("@entrada", txtEntradaG1.Text.Trim());
                    cmd.Parameters.AddWithValue("@salida", txtSalidaG1.Text.Trim());
                    cmd.Parameters.AddWithValue("@tolerancia", string.IsNullOrWhiteSpace(txtToleranciaG1.Text) ? 10 : Convert.ToInt32(txtToleranciaG1.Text.Trim()));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Turno guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SubLimpiarTurnoG1();
                    SubCargarTurnosG1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // EVENTO: LIMPIAR CAMPOS DE TURNO
        // ==========================================
        private void btnLimpiarTurnoG1_Click(object sender, EventArgs e)
        {
            SubLimpiarTurnoG1();
        }

        // ==========================================
        // EVENTO: ASIGNAR TURNO A EMPLEADO
        // ==========================================
        private void btnAsignarG1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEmpleadoAsignarG1.Text) || string.IsNullOrWhiteSpace(txtIdTurnoAsignarG1.Text))
            {
                MessageBox.Show("Ingrese el ID del empleado y el ID del turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();

                    string query = @"INSERT INTO AsignacionTurnos (IdEmpleado, IdTurno, FechaProgramada) 
                                     VALUES (@idEmpleado, @idTurno, @fecha)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idEmpleado", Convert.ToInt32(txtIdEmpleadoAsignarG1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@idTurno", Convert.ToInt32(txtIdTurnoAsignarG1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaG1.Value.Date);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Turno asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SubLimpiarAsignacionG1();
                    SubCargarTurnosG1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // EVENTO: ELIMINAR TURNO
        // ==========================================
        private void btnEliminarTurnoG1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdTurnoEliminarG1.Text))
            {
                MessageBox.Show("Ingrese el ID del turno a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este turno?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No) return;

            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();
                    string query = "DELETE FROM Turnos WHERE IdTurno = @id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", txtIdTurnoEliminarG1.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Turno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SubLimpiarEliminarG1();
                    SubCargarTurnosG1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // EVENTO: LIMPIAR CAMPOS DE ELIMINACIÓN
        // ==========================================
        private void btnLimpiarEliminarG1_Click(object sender, EventArgs e)
        {
            SubLimpiarEliminarG1();
        }

        // ==========================================
        // MÉTODOS AUXILIARES
        // ==========================================
        private void SubLimpiarTurnoG1()
        {
            txtIdTurnoG1.Clear();
            txtNombreTurnoG1.Clear();
            txtEntradaG1.Clear();
            txtSalidaG1.Clear();
            txtToleranciaG1.Clear();
            txtNombreTurnoG1.Focus();
        }

        private void SubLimpiarAsignacionG1()
        {
            txtIdEmpleadoAsignarG1.Clear();
            txtIdTurnoAsignarG1.Clear();
            dtpFechaG1.Value = DateTime.Now;
            txtIdEmpleadoAsignarG1.Focus();
        }

        private void SubLimpiarEliminarG1()
        {
            txtIdTurnoEliminarG1.Clear();
            txtIdTurnoEliminarG1.Focus();
        }

        private void SubCargarTurnosG1()
        {
            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();
                    string query = "SELECT IdTurno, NombreTurno, HoraEntrada, HoraSalida, ToleranciaMinutos FROM Turnos ORDER BY IdTurno";
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dgvTurnosG1.DataSource = dt;

                    if (dgvTurnosG1.Columns.Count > 0)
                    {
                        dgvTurnosG1.Columns["IdTurno"].HeaderText = "ID";
                        dgvTurnosG1.Columns["NombreTurno"].HeaderText = "Turno";
                        dgvTurnosG1.Columns["HoraEntrada"].HeaderText = "Entrada";
                        dgvTurnosG1.Columns["HoraSalida"].HeaderText = "Salida";
                        dgvTurnosG1.Columns["ToleranciaMinutos"].HeaderText = "Tolerancia (min)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar turnos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}