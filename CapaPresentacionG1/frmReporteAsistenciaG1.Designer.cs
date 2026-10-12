namespace CapaPresentacionG1
{
    partial class frmReporteAsistenciaG1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTituloG1 = new System.Windows.Forms.Label();
            this.gpbMarcajeG1 = new System.Windows.Forms.GroupBox();
            this.lblNombreEmpleadoG1 = new System.Windows.Forms.Label();
            this.btnRegistrarSalidaG1 = new System.Windows.Forms.Button();
            this.btnRegistrarIngresoG1 = new System.Windows.Forms.Button();
            this.txtCodigoEmpleadoG1 = new System.Windows.Forms.TextBox();
            this.lblCodigoG1 = new System.Windows.Forms.Label();
            this.lblFechaG1 = new System.Windows.Forms.Label();
            this.dtpDesdeG1 = new System.Windows.Forms.DateTimePicker();
            this.lblHastaG1 = new System.Windows.Forms.Label();
            this.dtpHastaG1 = new System.Windows.Forms.DateTimePicker();
            this.lblIdEmpleadoG1 = new System.Windows.Forms.Label();
            this.txtIdEmpleadoG1 = new System.Windows.Forms.TextBox();
            this.btnBuscarG1 = new System.Windows.Forms.Button();
            this.dgvReporteAsistenciaG1 = new System.Windows.Forms.DataGridView();
            this.gpbMarcajeG1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistenciaG1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloG1
            // 
            this.lblTituloG1.AutoSize = true;
            this.lblTituloG1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblTituloG1.Location = new System.Drawing.Point(250, 20);
            this.lblTituloG1.Name = "lblTituloG1";
            this.lblTituloG1.Size = new System.Drawing.Size(262, 32);
            this.lblTituloG1.TabIndex = 0;
            this.lblTituloG1.Text = "Reporte de Asistencia";
            // 
            // gpbMarcajeG1
            // 
            this.gpbMarcajeG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.gpbMarcajeG1.Controls.Add(this.lblNombreEmpleadoG1);
            this.gpbMarcajeG1.Controls.Add(this.btnRegistrarSalidaG1);
            this.gpbMarcajeG1.Controls.Add(this.btnRegistrarIngresoG1);
            this.gpbMarcajeG1.Controls.Add(this.txtCodigoEmpleadoG1);
            this.gpbMarcajeG1.Controls.Add(this.lblCodigoG1);
            this.gpbMarcajeG1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gpbMarcajeG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.gpbMarcajeG1.Location = new System.Drawing.Point(12, 55);
            this.gpbMarcajeG1.Name = "gpbMarcajeG1";
            this.gpbMarcajeG1.Size = new System.Drawing.Size(776, 135);
            this.gpbMarcajeG1.TabIndex = 1;
            this.gpbMarcajeG1.TabStop = false;
            this.gpbMarcajeG1.Text = "Marcaje de Entrada/Salida";
            // 
            // lblNombreEmpleadoG1
            // 
            this.lblNombreEmpleadoG1.AutoSize = true;
            this.lblNombreEmpleadoG1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreEmpleadoG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblNombreEmpleadoG1.Location = new System.Drawing.Point(20, 70);
            this.lblNombreEmpleadoG1.Name = "lblNombreEmpleadoG1";
            this.lblNombreEmpleadoG1.Size = new System.Drawing.Size(0, 19);
            this.lblNombreEmpleadoG1.TabIndex = 4;
            // 
            // btnRegistrarSalidaG1
            // 
            this.btnRegistrarSalidaG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnRegistrarSalidaG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSalidaG1.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSalidaG1.Location = new System.Drawing.Point(449, 10);
            this.btnRegistrarSalidaG1.Name = "btnRegistrarSalidaG1";
            this.btnRegistrarSalidaG1.Size = new System.Drawing.Size(150, 30);
            this.btnRegistrarSalidaG1.TabIndex = 3;
            this.btnRegistrarSalidaG1.Text = "Registrar Salida";
            this.btnRegistrarSalidaG1.UseVisualStyleBackColor = false;
            this.btnRegistrarSalidaG1.Click += new System.EventHandler(this.btnRegistrarSalidaG1_Click);
            // 
            // btnRegistrarIngresoG1
            // 
            this.btnRegistrarIngresoG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnRegistrarIngresoG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarIngresoG1.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarIngresoG1.Location = new System.Drawing.Point(267, 10);
            this.btnRegistrarIngresoG1.Name = "btnRegistrarIngresoG1";
            this.btnRegistrarIngresoG1.Size = new System.Drawing.Size(150, 30);
            this.btnRegistrarIngresoG1.TabIndex = 2;
            this.btnRegistrarIngresoG1.Text = "Registrar Ingreso";
            this.btnRegistrarIngresoG1.UseVisualStyleBackColor = false;
            this.btnRegistrarIngresoG1.Click += new System.EventHandler(this.btnRegistrarIngresoG1_Click);
            // 
            // txtCodigoEmpleadoG1
            // 
            this.txtCodigoEmpleadoG1.Location = new System.Drawing.Point(267, 55);
            this.txtCodigoEmpleadoG1.Name = "txtCodigoEmpleadoG1";
            this.txtCodigoEmpleadoG1.Size = new System.Drawing.Size(180, 25);
            this.txtCodigoEmpleadoG1.TabIndex = 1;
            // 
            // lblCodigoG1
            // 
            this.lblCodigoG1.AutoSize = true;
            this.lblCodigoG1.Location = new System.Drawing.Point(20, 30);
            this.lblCodigoG1.Name = "lblCodigoG1";
            this.lblCodigoG1.Size = new System.Drawing.Size(131, 19);
            this.lblCodigoG1.TabIndex = 0;
            this.lblCodigoG1.Text = "Código de Carnet:";
            // 
            // lblFechaG1
            // 
            this.lblFechaG1.AutoSize = true;
            this.lblFechaG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblFechaG1.Location = new System.Drawing.Point(21, 197);
            this.lblFechaG1.Name = "lblFechaG1";
            this.lblFechaG1.Size = new System.Drawing.Size(50, 19);
            this.lblFechaG1.TabIndex = 2;
            this.lblFechaG1.Text = "Desde:";
            // 
            // dtpDesdeG1
            // 
            this.dtpDesdeG1.Location = new System.Drawing.Point(74, 196);
            this.dtpDesdeG1.Name = "dtpDesdeG1";
            this.dtpDesdeG1.Size = new System.Drawing.Size(222, 20);
            this.dtpDesdeG1.TabIndex = 3;
            // 
            // lblHastaG1
            // 
            this.lblHastaG1.AutoSize = true;
            this.lblHastaG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHastaG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblHastaG1.Location = new System.Drawing.Point(21, 219);
            this.lblHastaG1.Name = "lblHastaG1";
            this.lblHastaG1.Size = new System.Drawing.Size(47, 19);
            this.lblHastaG1.TabIndex = 4;
            this.lblHastaG1.Text = "Hasta:";
            // 
            // dtpHastaG1
            // 
            this.dtpHastaG1.Location = new System.Drawing.Point(74, 222);
            this.dtpHastaG1.Name = "dtpHastaG1";
            this.dtpHastaG1.Size = new System.Drawing.Size(222, 20);
            this.dtpHastaG1.TabIndex = 5;
            // 
            // lblIdEmpleadoG1
            // 
            this.lblIdEmpleadoG1.AutoSize = true;
            this.lblIdEmpleadoG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIdEmpleadoG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblIdEmpleadoG1.Location = new System.Drawing.Point(329, 199);
            this.lblIdEmpleadoG1.Name = "lblIdEmpleadoG1";
            this.lblIdEmpleadoG1.Size = new System.Drawing.Size(90, 19);
            this.lblIdEmpleadoG1.TabIndex = 6;
            this.lblIdEmpleadoG1.Text = "ID Empleado:";
            // 
            // txtIdEmpleadoG1
            // 
            this.txtIdEmpleadoG1.Location = new System.Drawing.Point(333, 225);
            this.txtIdEmpleadoG1.Name = "txtIdEmpleadoG1";
            this.txtIdEmpleadoG1.Size = new System.Drawing.Size(173, 20);
            this.txtIdEmpleadoG1.TabIndex = 7;
            // 
            // btnBuscarG1
            // 
            this.btnBuscarG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnBuscarG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBuscarG1.ForeColor = System.Drawing.Color.White;
            this.btnBuscarG1.Location = new System.Drawing.Point(559, 203);
            this.btnBuscarG1.Name = "btnBuscarG1";
            this.btnBuscarG1.Size = new System.Drawing.Size(104, 39);
            this.btnBuscarG1.TabIndex = 8;
            this.btnBuscarG1.Text = "Buscar";
            this.btnBuscarG1.UseVisualStyleBackColor = false;
            this.btnBuscarG1.Click += new System.EventHandler(this.btnBuscarG1_Click);
            // 
            // dgvReporteAsistenciaG1
            // 
            this.dgvReporteAsistenciaG1.AllowUserToAddRows = false;
            this.dgvReporteAsistenciaG1.AllowUserToDeleteRows = false;
            this.dgvReporteAsistenciaG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteAsistenciaG1.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteAsistenciaG1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteAsistenciaG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteAsistenciaG1.Location = new System.Drawing.Point(12, 260);
            this.dgvReporteAsistenciaG1.Name = "dgvReporteAsistenciaG1";
            this.dgvReporteAsistenciaG1.ReadOnly = true;
            this.dgvReporteAsistenciaG1.RowHeadersVisible = false;
            this.dgvReporteAsistenciaG1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteAsistenciaG1.Size = new System.Drawing.Size(776, 240);
            this.dgvReporteAsistenciaG1.TabIndex = 9;
            // 
            // frmReporteAsistenciaG1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.dgvReporteAsistenciaG1);
            this.Controls.Add(this.btnBuscarG1);
            this.Controls.Add(this.txtIdEmpleadoG1);
            this.Controls.Add(this.lblIdEmpleadoG1);
            this.Controls.Add(this.dtpHastaG1);
            this.Controls.Add(this.lblHastaG1);
            this.Controls.Add(this.dtpDesdeG1);
            this.Controls.Add(this.lblFechaG1);
            this.Controls.Add(this.gpbMarcajeG1);
            this.Controls.Add(this.lblTituloG1);
            this.Name = "frmReporteAsistenciaG1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Asistencia";
            this.gpbMarcajeG1.ResumeLayout(false);
            this.gpbMarcajeG1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteAsistenciaG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloG1;
        private System.Windows.Forms.GroupBox gpbMarcajeG1;
        private System.Windows.Forms.Label lblNombreEmpleadoG1;
        private System.Windows.Forms.Button btnRegistrarSalidaG1;
        private System.Windows.Forms.Button btnRegistrarIngresoG1;
        private System.Windows.Forms.TextBox txtCodigoEmpleadoG1;
        private System.Windows.Forms.Label lblCodigoG1;
        private System.Windows.Forms.Label lblFechaG1;
        private System.Windows.Forms.DateTimePicker dtpDesdeG1;
        private System.Windows.Forms.Label lblHastaG1;
        private System.Windows.Forms.DateTimePicker dtpHastaG1;
        private System.Windows.Forms.Label lblIdEmpleadoG1;
        private System.Windows.Forms.TextBox txtIdEmpleadoG1;
        private System.Windows.Forms.Button btnBuscarG1;
        private System.Windows.Forms.DataGridView dgvReporteAsistenciaG1;
    }
}