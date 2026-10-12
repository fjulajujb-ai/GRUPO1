namespace CapaPresentacionG1
{
    partial class frmLoginG1
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
            this.lblSubtituloG1 = new System.Windows.Forms.Label();
            this.lblUsuarioG1 = new System.Windows.Forms.Label();
            this.txtUsuarioG1 = new System.Windows.Forms.TextBox();
            this.lblContrasenaG1 = new System.Windows.Forms.Label();
            this.txtContrasenaG1 = new System.Windows.Forms.TextBox();
            this.btnIniciarSesionG1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloG1
            // 
            this.lblTituloG1.AutoSize = true;
            this.lblTituloG1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblTituloG1.Location = new System.Drawing.Point(50, 40);
            this.lblTituloG1.Name = "lblTituloG1";
            this.lblTituloG1.Size = new System.Drawing.Size(345, 37);
            this.lblTituloG1.TabIndex = 0;
            this.lblTituloG1.Text = "CONTROL DE ASISTENCIA";
            this.lblTituloG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtituloG1
            // 
            this.lblSubtituloG1.AutoSize = true;
            this.lblSubtituloG1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblSubtituloG1.Location = new System.Drawing.Point(120, 85);
            this.lblSubtituloG1.Name = "lblSubtituloG1";
            this.lblSubtituloG1.Size = new System.Drawing.Size(144, 21);
            this.lblSubtituloG1.TabIndex = 1;
            this.lblSubtituloG1.Text = "Recursos Humanos";
            this.lblSubtituloG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioG1
            // 
            this.lblUsuarioG1.AutoSize = true;
            this.lblUsuarioG1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblUsuarioG1.Location = new System.Drawing.Point(60, 140);
            this.lblUsuarioG1.Name = "lblUsuarioG1";
            this.lblUsuarioG1.Size = new System.Drawing.Size(64, 19);
            this.lblUsuarioG1.TabIndex = 2;
            this.lblUsuarioG1.Text = "Usuario:";
            // 
            // txtUsuarioG1
            // 
            this.txtUsuarioG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuarioG1.Location = new System.Drawing.Point(60, 165);
            this.txtUsuarioG1.Name = "txtUsuarioG1";
            this.txtUsuarioG1.Size = new System.Drawing.Size(300, 25);
            this.txtUsuarioG1.TabIndex = 3;
            // 
            // lblContrasenaG1
            // 
            this.lblContrasenaG1.AutoSize = true;
            this.lblContrasenaG1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblContrasenaG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblContrasenaG1.Location = new System.Drawing.Point(60, 210);
            this.lblContrasenaG1.Name = "lblContrasenaG1";
            this.lblContrasenaG1.Size = new System.Drawing.Size(88, 19);
            this.lblContrasenaG1.TabIndex = 4;
            this.lblContrasenaG1.Text = "Contraseña:";
            // 
            // txtContrasenaG1
            // 
            this.txtContrasenaG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasenaG1.Location = new System.Drawing.Point(60, 235);
            this.txtContrasenaG1.Name = "txtContrasenaG1";
            this.txtContrasenaG1.PasswordChar = '*';
            this.txtContrasenaG1.Size = new System.Drawing.Size(300, 25);
            this.txtContrasenaG1.TabIndex = 5;
            // 
            // btnIniciarSesionG1
            // 
            this.btnIniciarSesionG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnIniciarSesionG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesionG1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesionG1.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesionG1.Location = new System.Drawing.Point(60, 300);
            this.btnIniciarSesionG1.Name = "btnIniciarSesionG1";
            this.btnIniciarSesionG1.Size = new System.Drawing.Size(300, 45);
            this.btnIniciarSesionG1.TabIndex = 6;
            this.btnIniciarSesionG1.Text = "Iniciar Sesión";
            this.btnIniciarSesionG1.UseVisualStyleBackColor = false;
            this.btnIniciarSesionG1.Click += new System.EventHandler(this.btnIniciarSesionG1_Click);
            // 
            // frmLoginG1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.btnIniciarSesionG1);
            this.Controls.Add(this.txtContrasenaG1);
            this.Controls.Add(this.lblContrasenaG1);
            this.Controls.Add(this.txtUsuarioG1);
            this.Controls.Add(this.lblUsuarioG1);
            this.Controls.Add(this.lblSubtituloG1);
            this.Controls.Add(this.lblTituloG1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLoginG1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloG1;
        private System.Windows.Forms.Label lblSubtituloG1;
        private System.Windows.Forms.Label lblUsuarioG1;
        private System.Windows.Forms.TextBox txtUsuarioG1;
        private System.Windows.Forms.Label lblContrasenaG1;
        private System.Windows.Forms.TextBox txtContrasenaG1;
        private System.Windows.Forms.Button btnIniciarSesionG1;
    }
}