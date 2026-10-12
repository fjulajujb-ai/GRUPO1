namespace CapaPresentacionG1
{
    partial class frmEmpleadosG1
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
            this.gpbNuevoG1 = new System.Windows.Forms.GroupBox();
            this.chkActivoG1 = new System.Windows.Forms.CheckBox();
            this.lblActivoG1 = new System.Windows.Forms.Label();
            this.txtIdDeptoG1 = new System.Windows.Forms.TextBox();
            this.lblIdDeptoG1 = new System.Windows.Forms.Label();
            this.txtApellidosG1 = new System.Windows.Forms.TextBox();
            this.lblApellidosG1 = new System.Windows.Forms.Label();
            this.txtNombresG1 = new System.Windows.Forms.TextBox();
            this.lblNombresG1 = new System.Windows.Forms.Label();
            this.txtCodigoG1 = new System.Windows.Forms.TextBox();
            this.lblCodigoG1 = new System.Windows.Forms.Label();
            this.txtIdEmpleadoG1 = new System.Windows.Forms.TextBox();
            this.lblIdEmpleadoG1 = new System.Windows.Forms.Label();
            this.btnGuardarG1 = new System.Windows.Forms.Button();
            this.btnLimpiarG1 = new System.Windows.Forms.Button();
            this.dgvEmpleadosG1 = new System.Windows.Forms.DataGridView();
            this.gpbEliminarG1 = new System.Windows.Forms.GroupBox();
            this.txtApellidosEliminarG1 = new System.Windows.Forms.TextBox();
            this.lblApellidosEliminarG1 = new System.Windows.Forms.Label();
            this.txtNombresEliminarG1 = new System.Windows.Forms.TextBox();
            this.lblNombresEliminarG1 = new System.Windows.Forms.Label();
            this.txtIdEliminarG1 = new System.Windows.Forms.TextBox();
            this.lblIdEliminarG1 = new System.Windows.Forms.Label();
            this.btnBuscarG1 = new System.Windows.Forms.Button();
            this.btnEliminarG1 = new System.Windows.Forms.Button();
            this.btnLimpiarEliminarG1 = new System.Windows.Forms.Button();
            this.gpbNuevoG1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosG1)).BeginInit();
            this.gpbEliminarG1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloG1
            // 
            this.lblTituloG1.AutoSize = true;
            this.lblTituloG1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblTituloG1.Location = new System.Drawing.Point(256, 9);
            this.lblTituloG1.Name = "lblTituloG1";
            this.lblTituloG1.Size = new System.Drawing.Size(267, 32);
            this.lblTituloG1.TabIndex = 0;
            this.lblTituloG1.Text = "Gestión de Empleados";
            // 
            // gpbNuevoG1
            // 
            this.gpbNuevoG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.gpbNuevoG1.Controls.Add(this.chkActivoG1);
            this.gpbNuevoG1.Controls.Add(this.lblActivoG1);
            this.gpbNuevoG1.Controls.Add(this.txtIdDeptoG1);
            this.gpbNuevoG1.Controls.Add(this.lblIdDeptoG1);
            this.gpbNuevoG1.Controls.Add(this.txtApellidosG1);
            this.gpbNuevoG1.Controls.Add(this.lblApellidosG1);
            this.gpbNuevoG1.Controls.Add(this.txtNombresG1);
            this.gpbNuevoG1.Controls.Add(this.lblNombresG1);
            this.gpbNuevoG1.Controls.Add(this.txtCodigoG1);
            this.gpbNuevoG1.Controls.Add(this.lblCodigoG1);
            this.gpbNuevoG1.Controls.Add(this.txtIdEmpleadoG1);
            this.gpbNuevoG1.Controls.Add(this.lblIdEmpleadoG1);
            this.gpbNuevoG1.Controls.Add(this.btnGuardarG1);
            this.gpbNuevoG1.Controls.Add(this.btnLimpiarG1);
            this.gpbNuevoG1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gpbNuevoG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.gpbNuevoG1.Location = new System.Drawing.Point(12, 60);
            this.gpbNuevoG1.Name = "gpbNuevoG1";
            this.gpbNuevoG1.Size = new System.Drawing.Size(776, 150);
            this.gpbNuevoG1.TabIndex = 1;
            this.gpbNuevoG1.TabStop = false;
            this.gpbNuevoG1.Text = "Nuevo Empleado";
            // 
            // chkActivoG1
            // 
            this.chkActivoG1.AutoSize = true;
            this.chkActivoG1.Location = new System.Drawing.Point(533, 57);
            this.chkActivoG1.Name = "chkActivoG1";
            this.chkActivoG1.Size = new System.Drawing.Size(15, 14);
            this.chkActivoG1.TabIndex = 13;
            this.chkActivoG1.UseVisualStyleBackColor = true;
            // 
            // lblActivoG1
            // 
            this.lblActivoG1.AutoSize = true;
            this.lblActivoG1.Location = new System.Drawing.Point(479, 53);
            this.lblActivoG1.Name = "lblActivoG1";
            this.lblActivoG1.Size = new System.Drawing.Size(56, 19);
            this.lblActivoG1.TabIndex = 12;
            this.lblActivoG1.Text = "Activo:";
            // 
            // txtIdDeptoG1
            // 
            this.txtIdDeptoG1.Location = new System.Drawing.Point(615, 19);
            this.txtIdDeptoG1.Name = "txtIdDeptoG1";
            this.txtIdDeptoG1.Size = new System.Drawing.Size(100, 25);
            this.txtIdDeptoG1.TabIndex = 11;
            // 
            // lblIdDeptoG1
            // 
            this.lblIdDeptoG1.AutoSize = true;
            this.lblIdDeptoG1.Location = new System.Drawing.Point(481, 22);
            this.lblIdDeptoG1.Name = "lblIdDeptoG1";
            this.lblIdDeptoG1.Size = new System.Drawing.Size(128, 19);
            this.lblIdDeptoG1.TabIndex = 10;
            this.lblIdDeptoG1.Text = "ID Departamento:";
            // 
            // txtApellidosG1
            // 
            this.txtApellidosG1.Location = new System.Drawing.Point(100, 98);
            this.txtApellidosG1.Name = "txtApellidosG1";
            this.txtApellidosG1.Size = new System.Drawing.Size(234, 25);
            this.txtApellidosG1.TabIndex = 9;
            // 
            // lblApellidosG1
            // 
            this.lblApellidosG1.AutoSize = true;
            this.lblApellidosG1.Location = new System.Drawing.Point(20, 98);
            this.lblApellidosG1.Name = "lblApellidosG1";
            this.lblApellidosG1.Size = new System.Drawing.Size(76, 19);
            this.lblApellidosG1.TabIndex = 8;
            this.lblApellidosG1.Text = "Apellidos:";
            // 
            // txtNombresG1
            // 
            this.txtNombresG1.Location = new System.Drawing.Point(100, 65);
            this.txtNombresG1.Name = "txtNombresG1";
            this.txtNombresG1.Size = new System.Drawing.Size(300, 25);
            this.txtNombresG1.TabIndex = 7;
            // 
            // lblNombresG1
            // 
            this.lblNombresG1.AutoSize = true;
            this.lblNombresG1.Location = new System.Drawing.Point(19, 62);
            this.lblNombresG1.Name = "lblNombresG1";
            this.lblNombresG1.Size = new System.Drawing.Size(75, 19);
            this.lblNombresG1.TabIndex = 6;
            this.lblNombresG1.Text = "Nombres:";
            // 
            // txtCodigoG1
            // 
            this.txtCodigoG1.Location = new System.Drawing.Point(350, 25);
            this.txtCodigoG1.Name = "txtCodigoG1";
            this.txtCodigoG1.Size = new System.Drawing.Size(120, 25);
            this.txtCodigoG1.TabIndex = 5;
            // 
            // lblCodigoG1
            // 
            this.lblCodigoG1.AutoSize = true;
            this.lblCodigoG1.Location = new System.Drawing.Point(234, 25);
            this.lblCodigoG1.Name = "lblCodigoG1";
            this.lblCodigoG1.Size = new System.Drawing.Size(110, 19);
            this.lblCodigoG1.TabIndex = 4;
            this.lblCodigoG1.Text = "Código Carnet:";
            // 
            // txtIdEmpleadoG1
            // 
            this.txtIdEmpleadoG1.Location = new System.Drawing.Point(100, 25);
            this.txtIdEmpleadoG1.Name = "txtIdEmpleadoG1";
            this.txtIdEmpleadoG1.ReadOnly = true;
            this.txtIdEmpleadoG1.Size = new System.Drawing.Size(110, 25);
            this.txtIdEmpleadoG1.TabIndex = 3;
            // 
            // lblIdEmpleadoG1
            // 
            this.lblIdEmpleadoG1.AutoSize = true;
            this.lblIdEmpleadoG1.Location = new System.Drawing.Point(20, 30);
            this.lblIdEmpleadoG1.Name = "lblIdEmpleadoG1";
            this.lblIdEmpleadoG1.Size = new System.Drawing.Size(64, 19);
            this.lblIdEmpleadoG1.TabIndex = 2;
            this.lblIdEmpleadoG1.Text = "ID Emp.:";
            // 
            // btnGuardarG1
            // 
            this.btnGuardarG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnGuardarG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarG1.ForeColor = System.Drawing.Color.White;
            this.btnGuardarG1.Location = new System.Drawing.Point(429, 98);
            this.btnGuardarG1.Name = "btnGuardarG1";
            this.btnGuardarG1.Size = new System.Drawing.Size(180, 30);
            this.btnGuardarG1.TabIndex = 0;
            this.btnGuardarG1.Text = "Guardar Nuevo Empleado";
            this.btnGuardarG1.UseVisualStyleBackColor = false;
            this.btnGuardarG1.Click += new System.EventHandler(this.btnGuardarG1_Click);
            // 
            // btnLimpiarG1
            // 
            this.btnLimpiarG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnLimpiarG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarG1.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarG1.Location = new System.Drawing.Point(643, 98);
            this.btnLimpiarG1.Name = "btnLimpiarG1";
            this.btnLimpiarG1.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiarG1.TabIndex = 1;
            this.btnLimpiarG1.Text = "Limpiar";
            this.btnLimpiarG1.UseVisualStyleBackColor = false;
            this.btnLimpiarG1.Click += new System.EventHandler(this.btnLimpiarG1_Click);
            // 
            // dgvEmpleadosG1
            // 
            this.dgvEmpleadosG1.AllowUserToAddRows = false;
            this.dgvEmpleadosG1.AllowUserToDeleteRows = false;
            this.dgvEmpleadosG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleadosG1.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleadosG1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleadosG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosG1.Location = new System.Drawing.Point(12, 220);
            this.dgvEmpleadosG1.Name = "dgvEmpleadosG1";
            this.dgvEmpleadosG1.ReadOnly = true;
            this.dgvEmpleadosG1.RowHeadersVisible = false;
            this.dgvEmpleadosG1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosG1.Size = new System.Drawing.Size(776, 180);
            this.dgvEmpleadosG1.TabIndex = 2;
            // 
            // gpbEliminarG1
            // 
            this.gpbEliminarG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.gpbEliminarG1.Controls.Add(this.txtApellidosEliminarG1);
            this.gpbEliminarG1.Controls.Add(this.lblApellidosEliminarG1);
            this.gpbEliminarG1.Controls.Add(this.txtNombresEliminarG1);
            this.gpbEliminarG1.Controls.Add(this.lblNombresEliminarG1);
            this.gpbEliminarG1.Controls.Add(this.txtIdEliminarG1);
            this.gpbEliminarG1.Controls.Add(this.lblIdEliminarG1);
            this.gpbEliminarG1.Controls.Add(this.btnBuscarG1);
            this.gpbEliminarG1.Controls.Add(this.btnEliminarG1);
            this.gpbEliminarG1.Controls.Add(this.btnLimpiarEliminarG1);
            this.gpbEliminarG1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gpbEliminarG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.gpbEliminarG1.Location = new System.Drawing.Point(12, 406);
            this.gpbEliminarG1.Name = "gpbEliminarG1";
            this.gpbEliminarG1.Size = new System.Drawing.Size(776, 130);
            this.gpbEliminarG1.TabIndex = 3;
            this.gpbEliminarG1.TabStop = false;
            this.gpbEliminarG1.Text = "Eliminar Empleado";
            // 
            // txtApellidosEliminarG1
            // 
            this.txtApellidosEliminarG1.Location = new System.Drawing.Point(533, 67);
            this.txtApellidosEliminarG1.Name = "txtApellidosEliminarG1";
            this.txtApellidosEliminarG1.ReadOnly = true;
            this.txtApellidosEliminarG1.Size = new System.Drawing.Size(200, 25);
            this.txtApellidosEliminarG1.TabIndex = 8;
            // 
            // lblApellidosEliminarG1
            // 
            this.lblApellidosEliminarG1.AutoSize = true;
            this.lblApellidosEliminarG1.Location = new System.Drawing.Point(414, 73);
            this.lblApellidosEliminarG1.Name = "lblApellidosEliminarG1";
            this.lblApellidosEliminarG1.Size = new System.Drawing.Size(76, 19);
            this.lblApellidosEliminarG1.TabIndex = 7;
            this.lblApellidosEliminarG1.Text = "Apellidos:";
            // 
            // txtNombresEliminarG1
            // 
            this.txtNombresEliminarG1.Location = new System.Drawing.Point(100, 70);
            this.txtNombresEliminarG1.Name = "txtNombresEliminarG1";
            this.txtNombresEliminarG1.ReadOnly = true;
            this.txtNombresEliminarG1.Size = new System.Drawing.Size(264, 25);
            this.txtNombresEliminarG1.TabIndex = 6;
            // 
            // lblNombresEliminarG1
            // 
            this.lblNombresEliminarG1.AutoSize = true;
            this.lblNombresEliminarG1.Location = new System.Drawing.Point(20, 70);
            this.lblNombresEliminarG1.Name = "lblNombresEliminarG1";
            this.lblNombresEliminarG1.Size = new System.Drawing.Size(75, 19);
            this.lblNombresEliminarG1.TabIndex = 5;
            this.lblNombresEliminarG1.Text = "Nombres:";
            // 
            // txtIdEliminarG1
            // 
            this.txtIdEliminarG1.Location = new System.Drawing.Point(100, 30);
            this.txtIdEliminarG1.Name = "txtIdEliminarG1";
            this.txtIdEliminarG1.Size = new System.Drawing.Size(144, 25);
            this.txtIdEliminarG1.TabIndex = 4;
            // 
            // lblIdEliminarG1
            // 
            this.lblIdEliminarG1.AutoSize = true;
            this.lblIdEliminarG1.Location = new System.Drawing.Point(20, 30);
            this.lblIdEliminarG1.Name = "lblIdEliminarG1";
            this.lblIdEliminarG1.Size = new System.Drawing.Size(64, 19);
            this.lblIdEliminarG1.TabIndex = 3;
            this.lblIdEliminarG1.Text = "ID Emp.:";
            // 
            // btnBuscarG1
            // 
            this.btnBuscarG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnBuscarG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarG1.ForeColor = System.Drawing.Color.White;
            this.btnBuscarG1.Location = new System.Drawing.Point(281, 26);
            this.btnBuscarG1.Name = "btnBuscarG1";
            this.btnBuscarG1.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarG1.TabIndex = 2;
            this.btnBuscarG1.Text = "Buscar";
            this.btnBuscarG1.UseVisualStyleBackColor = false;
            this.btnBuscarG1.Click += new System.EventHandler(this.btnGuardarG1_Click);
            // 
            // btnEliminarG1
            // 
            this.btnEliminarG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnEliminarG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarG1.ForeColor = System.Drawing.Color.White;
            this.btnEliminarG1.Location = new System.Drawing.Point(401, 26);
            this.btnEliminarG1.Name = "btnEliminarG1";
            this.btnEliminarG1.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarG1.TabIndex = 1;
            this.btnEliminarG1.Text = "Eliminar";
            this.btnEliminarG1.UseVisualStyleBackColor = false;
            this.btnEliminarG1.Click += new System.EventHandler(this.btnEliminarG1_Click);
            // 
            // btnLimpiarEliminarG1
            // 
            this.btnLimpiarEliminarG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnLimpiarEliminarG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEliminarG1.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarEliminarG1.Location = new System.Drawing.Point(531, 26);
            this.btnLimpiarEliminarG1.Name = "btnLimpiarEliminarG1";
            this.btnLimpiarEliminarG1.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiarEliminarG1.TabIndex = 0;
            this.btnLimpiarEliminarG1.Text = "Limpiar";
            this.btnLimpiarEliminarG1.UseVisualStyleBackColor = false;
            this.btnLimpiarEliminarG1.Click += new System.EventHandler(this.btnLimpiarEliminarG1_Click);
            // 
            // frmEmpleadosG1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.gpbEliminarG1);
            this.Controls.Add(this.dgvEmpleadosG1);
            this.Controls.Add(this.gpbNuevoG1);
            this.Controls.Add(this.lblTituloG1);
            this.Name = "frmEmpleadosG1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Empleados";
            this.gpbNuevoG1.ResumeLayout(false);
            this.gpbNuevoG1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosG1)).EndInit();
            this.gpbEliminarG1.ResumeLayout(false);
            this.gpbEliminarG1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloG1;
        private System.Windows.Forms.GroupBox gpbNuevoG1;
        private System.Windows.Forms.CheckBox chkActivoG1;
        private System.Windows.Forms.Label lblActivoG1;
        private System.Windows.Forms.TextBox txtIdDeptoG1;
        private System.Windows.Forms.Label lblIdDeptoG1;
        private System.Windows.Forms.TextBox txtApellidosG1;
        private System.Windows.Forms.Label lblApellidosG1;
        private System.Windows.Forms.TextBox txtNombresG1;
        private System.Windows.Forms.Label lblNombresG1;
        private System.Windows.Forms.TextBox txtCodigoG1;
        private System.Windows.Forms.Label lblCodigoG1;
        private System.Windows.Forms.TextBox txtIdEmpleadoG1;
        private System.Windows.Forms.Label lblIdEmpleadoG1;
        private System.Windows.Forms.Button btnGuardarG1;
        private System.Windows.Forms.Button btnLimpiarG1;
        private System.Windows.Forms.DataGridView dgvEmpleadosG1;
        private System.Windows.Forms.GroupBox gpbEliminarG1;
        private System.Windows.Forms.TextBox txtApellidosEliminarG1;
        private System.Windows.Forms.Label lblApellidosEliminarG1;
        private System.Windows.Forms.TextBox txtNombresEliminarG1;
        private System.Windows.Forms.Label lblNombresEliminarG1;
        private System.Windows.Forms.TextBox txtIdEliminarG1;
        private System.Windows.Forms.Label lblIdEliminarG1;
        private System.Windows.Forms.Button btnBuscarG1;
        private System.Windows.Forms.Button btnEliminarG1;
        private System.Windows.Forms.Button btnLimpiarEliminarG1;
    }
}