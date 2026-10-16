using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaAccesoDatosG1;

namespace CapaPresentacionG1
{
    public partial class frmEmpleadosG1 : Form
    {
        public frmEmpleadosG1()
        {
            InitializeComponent();
            SubCargarEmpleadosG1();
        }

        // ==========================================
        // EVENTO: GUARDAR NUEVO EMPLEADO
        // ==========================================
        private void btnGuardarG1_Click(object sender, EventArgs e)
        {
            // Validaciones existentes...
            if (string.IsNullOrWhiteSpace(txtCodigoG1.Text)) { MessageBox.Show("Ingrese el código de carnet."); return; }
            if (string.IsNullOrWhiteSpace(txtNombresG1.Text)) { MessageBox.Show("Ingrese los nombres."); return; }
            if (string.IsNullOrWhiteSpace(txtApellidosG1.Text)) { MessageBox.Show("Ingrese los apellidos."); return; }
            if (string.IsNullOrWhiteSpace(txtIdDeptoG1.Text)) { MessageBox.Show("Ingrese el ID del departamento."); return; }
            // NUEVAS validaciones
            if (string.IsNullOrWhiteSpace(txtPuestoG1.Text)) { MessageBox.Show("Ingrese el puesto."); return; }
            if (string.IsNullOrWhiteSpace(txtSalarioG1.Text)) { MessageBox.Show("Ingrese el salario base."); return; }

            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();

                    // Verificar que el código no exista
                    string queryVerificar = "SELECT COUNT(*) FROM Empleados WHERE CodigoCarnet = @codigo";
                    SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexion);
                    cmdVerificar.Parameters.AddWithValue("@codigo", txtCodigoG1.Text.Trim());
                    int existe = (int)cmdVerificar.ExecuteScalar();
                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe un empleado con ese código de carnet.");
                        return;
                    }

                    // Insertar con los nuevos campos
                    string query = @"INSERT INTO Empleados (CodigoCarnet, Nombres, Apellidos, IdDepartamento, Puesto, SalarioBase, Activo) 
                             VALUES (@codigo, @nombres, @apellidos, @idDepto, @puesto, @salario, @activo)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@codigo", txtCodigoG1.Text.Trim());
                    cmd.Parameters.AddWithValue("@nombres", txtNombresG1.Text.Trim());
                    cmd.Parameters.AddWithValue("@apellidos", txtApellidosG1.Text.Trim());
                    cmd.Parameters.AddWithValue("@idDepto", Convert.ToInt32(txtIdDeptoG1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@puesto", txtPuestoG1.Text.Trim());
                    cmd.Parameters.AddWithValue("@salario", Convert.ToDecimal(txtSalarioG1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@activo", chkActivoG1.Checked ? 1 : 0);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Empleado guardado correctamente.");
                    
                    SubCargarEmpleadosG1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // ==========================================
        // EVENTO: LIMPIAR CAMPOS
        // ==========================================
        private void SubLimpiarG1()
        {
            txtIdEmpleadoG1.Clear();
            txtCodigoG1.Clear();
            txtNombresG1.Clear();
            txtApellidosG1.Clear();
            txtIdDeptoG1.Clear();
            txtPuestoG1.Clear();      // NUEVO
            txtSalarioG1.Clear();     // NUEVO
            chkActivoG1.Checked = true;
            txtCodigoG1.Focus();
        }
        // ==========================================
        // EVENTO: BUSCAR EMPLEADO
        // ==========================================
        private void btnBuscarG1_Click(object sender, EventArgs e)
        {

        }

        // ==========================================
        // EVENTO: ELIMINAR EMPLEADO
        // ==========================================
        private void btnEliminarG1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEliminarG1.Text))
            {
                MessageBox.Show("Ingrese el ID del empleado a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No) return;

            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();
                    string query = "DELETE FROM Empleados WHERE IdEmpleado = @id";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", txtIdEliminarG1.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SubLimpiarEliminarG1();
                    SubCargarEmpleadosG1();
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


        private void SubLimpiarEliminarG1()
        {
            txtIdEliminarG1.Clear();
            txtNombresEliminarG1.Clear();
            txtApellidosEliminarG1.Clear();
            txtIdEliminarG1.Focus();
        }
        // ==========================================
        // EVENTO: LIMPIAR CAMPOS (BOTÓN LIMPIAR)
        // ==========================================
        private void btnLimpiarG1_Click(object sender, EventArgs e)
        {
            SubLimpiarG1();
        }

        private void SubCargarEmpleadosG1()
        {
            try
            {
                using (SqlConnection conexion = ConexionG1.SubObtenerConexionG1())
                {
                    conexion.Open();
                    string query = @"
                SELECT 
                    E.IdEmpleado,
                    E.CodigoCarnet,
                    E.Nombres,
                    E.Apellidos,
                    E.Puesto,
                    E.SalarioBase,
                    D.NombreDepartamento,
                    E.Activo
                FROM Empleados E
                INNER JOIN Departamentos D ON E.IdDepartamento = D.IdDepartamento
                ORDER BY E.IdEmpleado DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dgvEmpleadosG1.DataSource = dt;

                    if (dgvEmpleadosG1.Columns.Count > 0)
                    {
                        dgvEmpleadosG1.Columns["IdEmpleado"].HeaderText = "ID";
                        dgvEmpleadosG1.Columns["CodigoCarnet"].HeaderText = "Código";
                        dgvEmpleadosG1.Columns["Nombres"].HeaderText = "Nombres";
                        dgvEmpleadosG1.Columns["Apellidos"].HeaderText = "Apellidos";
                        dgvEmpleadosG1.Columns["Puesto"].HeaderText = "Puesto";
                        dgvEmpleadosG1.Columns["SalarioBase"].HeaderText = "Salario Base";
                        dgvEmpleadosG1.Columns["SalarioBase"].DefaultCellStyle.Format = "N2";
                        dgvEmpleadosG1.Columns["NombreDepartamento"].HeaderText = "Departamento";
                        dgvEmpleadosG1.Columns["Activo"].HeaderText = "Activo";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }
    
    }
}