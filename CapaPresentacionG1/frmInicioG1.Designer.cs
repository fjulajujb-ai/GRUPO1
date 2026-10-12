namespace CapaPresentacionG1
{
    partial class frmInicioG1
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
            this.pnlHeaderG1 = new System.Windows.Forms.Panel();
            this.lblTituloG1 = new System.Windows.Forms.Label();
            this.pnlCard1G1 = new System.Windows.Forms.Panel();
            this.lblTotalEmpleadosG1 = new System.Windows.Forms.Label();
            this.lblCard1TituloG1 = new System.Windows.Forms.Label();
            this.pnlCard2G1 = new System.Windows.Forms.Panel();
            this.lblPresentesG1 = new System.Windows.Forms.Label();
            this.lblCard2TituloG1 = new System.Windows.Forms.Label();
            this.pnlCard3G1 = new System.Windows.Forms.Panel();
            this.lblTardanzasG1 = new System.Windows.Forms.Label();
            this.lblCard3TituloG1 = new System.Windows.Forms.Label();
            this.btnMarcarAsistenciaG1 = new System.Windows.Forms.Button();
            this.lblResumenG1 = new System.Windows.Forms.Label();
            this.dgvResumenAsistenciaG1 = new System.Windows.Forms.DataGridView();
            this.lblAlertasG1 = new System.Windows.Forms.Label();
            this.dgvAlertasTardanzasG1 = new System.Windows.Forms.DataGridView();
            this.pnlAsistenciaG1 = new System.Windows.Forms.Panel();
            this.lblPorcentajeAsistenciaG1 = new System.Windows.Forms.Label();
            this.lblAsistenciaTituloG1 = new System.Windows.Forms.Label();
            this.pnlHeaderG1.SuspendLayout();
            this.pnlCard1G1.SuspendLayout();
            this.pnlCard2G1.SuspendLayout();
            this.pnlCard3G1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenAsistenciaG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertasTardanzasG1)).BeginInit();
            this.pnlAsistenciaG1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderG1
            // 
            this.pnlHeaderG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.pnlHeaderG1.Controls.Add(this.lblTituloG1);
            this.pnlHeaderG1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderG1.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderG1.Name = "pnlHeaderG1";
            this.pnlHeaderG1.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeaderG1.TabIndex = 0;
            // 
            // lblTituloG1
            // 
            this.lblTituloG1.AutoSize = true;
            this.lblTituloG1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTituloG1.ForeColor = System.Drawing.Color.White;
            this.lblTituloG1.Location = new System.Drawing.Point(20, 10);
            this.lblTituloG1.Name = "lblTituloG1";
            this.lblTituloG1.Size = new System.Drawing.Size(357, 41);
            this.lblTituloG1.TabIndex = 0;
            this.lblTituloG1.Text = "Panel de Control - Inicio";
            // 
            // pnlCard1G1
            // 
            this.pnlCard1G1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.pnlCard1G1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1G1.Controls.Add(this.lblTotalEmpleadosG1);
            this.pnlCard1G1.Controls.Add(this.lblCard1TituloG1);
            this.pnlCard1G1.Location = new System.Drawing.Point(50, 90);
            this.pnlCard1G1.Name = "pnlCard1G1";
            this.pnlCard1G1.Size = new System.Drawing.Size(280, 100);
            this.pnlCard1G1.TabIndex = 1;
            // 
            // lblTotalEmpleadosG1
            // 
            this.lblTotalEmpleadosG1.AutoSize = true;
            this.lblTotalEmpleadosG1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalEmpleadosG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblTotalEmpleadosG1.Location = new System.Drawing.Point(20, 40);
            this.lblTotalEmpleadosG1.Name = "lblTotalEmpleadosG1";
            this.lblTotalEmpleadosG1.Size = new System.Drawing.Size(44, 51);
            this.lblTotalEmpleadosG1.TabIndex = 1;
            this.lblTotalEmpleadosG1.Text = "0";
            // 
            // lblCard1TituloG1
            // 
            this.lblCard1TituloG1.AutoSize = true;
            this.lblCard1TituloG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard1TituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblCard1TituloG1.Location = new System.Drawing.Point(20, 15);
            this.lblCard1TituloG1.Name = "lblCard1TituloG1";
            this.lblCard1TituloG1.Size = new System.Drawing.Size(108, 19);
            this.lblCard1TituloG1.TabIndex = 0;
            this.lblCard1TituloG1.Text = "Total Empleados";
            // 
            // pnlCard2G1
            // 
            this.pnlCard2G1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.pnlCard2G1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2G1.Controls.Add(this.lblPresentesG1);
            this.pnlCard2G1.Controls.Add(this.lblCard2TituloG1);
            this.pnlCard2G1.Location = new System.Drawing.Point(360, 90);
            this.pnlCard2G1.Name = "pnlCard2G1";
            this.pnlCard2G1.Size = new System.Drawing.Size(280, 100);
            this.pnlCard2G1.TabIndex = 2;
            // 
            // lblPresentesG1
            // 
            this.lblPresentesG1.AutoSize = true;
            this.lblPresentesG1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblPresentesG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblPresentesG1.Location = new System.Drawing.Point(20, 40);
            this.lblPresentesG1.Name = "lblPresentesG1";
            this.lblPresentesG1.Size = new System.Drawing.Size(44, 51);
            this.lblPresentesG1.TabIndex = 1;
            this.lblPresentesG1.Text = "0";
            // 
            // lblCard2TituloG1
            // 
            this.lblCard2TituloG1.AutoSize = true;
            this.lblCard2TituloG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard2TituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblCard2TituloG1.Location = new System.Drawing.Point(20, 15);
            this.lblCard2TituloG1.Name = "lblCard2TituloG1";
            this.lblCard2TituloG1.Size = new System.Drawing.Size(97, 19);
            this.lblCard2TituloG1.TabIndex = 0;
            this.lblCard2TituloG1.Text = "Presentes Hoy";
            // 
            // pnlCard3G1
            // 
            this.pnlCard3G1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.pnlCard3G1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3G1.Controls.Add(this.lblTardanzasG1);
            this.pnlCard3G1.Controls.Add(this.lblCard3TituloG1);
            this.pnlCard3G1.Location = new System.Drawing.Point(670, 90);
            this.pnlCard3G1.Name = "pnlCard3G1";
            this.pnlCard3G1.Size = new System.Drawing.Size(280, 100);
            this.pnlCard3G1.TabIndex = 3;
            // 
            // lblTardanzasG1
            // 
            this.lblTardanzasG1.AutoSize = true;
            this.lblTardanzasG1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTardanzasG1.ForeColor = System.Drawing.Color.Red;
            this.lblTardanzasG1.Location = new System.Drawing.Point(20, 40);
            this.lblTardanzasG1.Name = "lblTardanzasG1";
            this.lblTardanzasG1.Size = new System.Drawing.Size(44, 51);
            this.lblTardanzasG1.TabIndex = 1;
            this.lblTardanzasG1.Text = "0";
            // 
            // lblCard3TituloG1
            // 
            this.lblCard3TituloG1.AutoSize = true;
            this.lblCard3TituloG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard3TituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblCard3TituloG1.Location = new System.Drawing.Point(20, 15);
            this.lblCard3TituloG1.Name = "lblCard3TituloG1";
            this.lblCard3TituloG1.Size = new System.Drawing.Size(97, 19);
            this.lblCard3TituloG1.TabIndex = 0;
            this.lblCard3TituloG1.Text = "Tardanzas Hoy";
            // 
            // btnMarcarAsistenciaG1
            // 
            this.btnMarcarAsistenciaG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.btnMarcarAsistenciaG1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarAsistenciaG1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMarcarAsistenciaG1.ForeColor = System.Drawing.Color.White;
            this.btnMarcarAsistenciaG1.Location = new System.Drawing.Point(360, 220);
            this.btnMarcarAsistenciaG1.Name = "btnMarcarAsistenciaG1";
            this.btnMarcarAsistenciaG1.Size = new System.Drawing.Size(280, 50);
            this.btnMarcarAsistenciaG1.TabIndex = 4;
            this.btnMarcarAsistenciaG1.Text = "📋 Marcar Asistencia";
            this.btnMarcarAsistenciaG1.UseVisualStyleBackColor = false;
            this.btnMarcarAsistenciaG1.Click += new System.EventHandler(this.btnMarcarAsistenciaG1_Click);
            // 
            // lblResumenG1
            // 
            this.lblResumenG1.AutoSize = true;
            this.lblResumenG1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResumenG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblResumenG1.Location = new System.Drawing.Point(50, 300);
            this.lblResumenG1.Name = "lblResumenG1";
            this.lblResumenG1.Size = new System.Drawing.Size(178, 25);
            this.lblResumenG1.TabIndex = 5;
            this.lblResumenG1.Text = "Últimas Asistencias";
            // 
            // dgvResumenAsistenciaG1
            // 
            this.dgvResumenAsistenciaG1.BackgroundColor = System.Drawing.Color.White;
            this.dgvResumenAsistenciaG1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResumenAsistenciaG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenAsistenciaG1.Location = new System.Drawing.Point(50, 340);
            this.dgvResumenAsistenciaG1.Name = "dgvResumenAsistenciaG1";
            this.dgvResumenAsistenciaG1.Size = new System.Drawing.Size(430, 200);
            this.dgvResumenAsistenciaG1.TabIndex = 6;
            // 
            // lblAlertasG1
            // 
            this.lblAlertasG1.AutoSize = true;
            this.lblAlertasG1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAlertasG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblAlertasG1.Location = new System.Drawing.Point(520, 300);
            this.lblAlertasG1.Name = "lblAlertasG1";
            this.lblAlertasG1.Size = new System.Drawing.Size(194, 25);
            this.lblAlertasG1.TabIndex = 7;
            this.lblAlertasG1.Text = "Alertas de Tardanzas";
            // 
            // dgvAlertasTardanzasG1
            // 
            this.dgvAlertasTardanzasG1.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlertasTardanzasG1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlertasTardanzasG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertasTardanzasG1.Location = new System.Drawing.Point(520, 340);
            this.dgvAlertasTardanzasG1.Name = "dgvAlertasTardanzasG1";
            this.dgvAlertasTardanzasG1.Size = new System.Drawing.Size(430, 200);
            this.dgvAlertasTardanzasG1.TabIndex = 8;
            // 
            // pnlAsistenciaG1
            // 
            this.pnlAsistenciaG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.pnlAsistenciaG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAsistenciaG1.Controls.Add(this.lblPorcentajeAsistenciaG1);
            this.pnlAsistenciaG1.Controls.Add(this.lblAsistenciaTituloG1);
            this.pnlAsistenciaG1.Location = new System.Drawing.Point(360, 570);
            this.pnlAsistenciaG1.Name = "pnlAsistenciaG1";
            this.pnlAsistenciaG1.Size = new System.Drawing.Size(280, 80);
            this.pnlAsistenciaG1.TabIndex = 9;
            // 
            // lblPorcentajeAsistenciaG1
            // 
            this.lblPorcentajeAsistenciaG1.AutoSize = true;
            this.lblPorcentajeAsistenciaG1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPorcentajeAsistenciaG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(88)))));
            this.lblPorcentajeAsistenciaG1.Location = new System.Drawing.Point(90, 30);
            this.lblPorcentajeAsistenciaG1.Name = "lblPorcentajeAsistenciaG1";
            this.lblPorcentajeAsistenciaG1.Size = new System.Drawing.Size(56, 37);
            this.lblPorcentajeAsistenciaG1.TabIndex = 1;
            this.lblPorcentajeAsistenciaG1.Text = "0%";
            // 
            // lblAsistenciaTituloG1
            // 
            this.lblAsistenciaTituloG1.AutoSize = true;
            this.lblAsistenciaTituloG1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAsistenciaTituloG1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(80)))), ((int)(((byte)(20)))));
            this.lblAsistenciaTituloG1.Location = new System.Drawing.Point(90, 10);
            this.lblAsistenciaTituloG1.Name = "lblAsistenciaTituloG1";
            this.lblAsistenciaTituloG1.Size = new System.Drawing.Size(98, 19);
            this.lblAsistenciaTituloG1.TabIndex = 0;
            this.lblAsistenciaTituloG1.Text = "Asistencia Hoy";
            // 
            // frmInicioG1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlAsistenciaG1);
            this.Controls.Add(this.dgvAlertasTardanzasG1);
            this.Controls.Add(this.lblAlertasG1);
            this.Controls.Add(this.dgvResumenAsistenciaG1);
            this.Controls.Add(this.lblResumenG1);
            this.Controls.Add(this.btnMarcarAsistenciaG1);
            this.Controls.Add(this.pnlCard3G1);
            this.Controls.Add(this.pnlCard2G1);
            this.Controls.Add(this.pnlCard1G1);
            this.Controls.Add(this.pnlHeaderG1);
            this.Name = "frmInicioG1";
            this.Text = "Inicio - Dashboard";
            this.pnlHeaderG1.ResumeLayout(false);
            this.pnlHeaderG1.PerformLayout();
            this.pnlCard1G1.ResumeLayout(false);
            this.pnlCard1G1.PerformLayout();
            this.pnlCard2G1.ResumeLayout(false);
            this.pnlCard2G1.PerformLayout();
            this.pnlCard3G1.ResumeLayout(false);
            this.pnlCard3G1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenAsistenciaG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertasTardanzasG1)).EndInit();
            this.pnlAsistenciaG1.ResumeLayout(false);
            this.pnlAsistenciaG1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderG1;
        private System.Windows.Forms.Label lblTituloG1;
        private System.Windows.Forms.Panel pnlCard1G1;
        private System.Windows.Forms.Label lblTotalEmpleadosG1;
        private System.Windows.Forms.Label lblCard1TituloG1;
        private System.Windows.Forms.Panel pnlCard2G1;
        private System.Windows.Forms.Label lblPresentesG1;
        private System.Windows.Forms.Label lblCard2TituloG1;
        private System.Windows.Forms.Panel pnlCard3G1;
        private System.Windows.Forms.Label lblTardanzasG1;
        private System.Windows.Forms.Label lblCard3TituloG1;
        private System.Windows.Forms.Button btnMarcarAsistenciaG1;
        private System.Windows.Forms.Label lblResumenG1;
        private System.Windows.Forms.DataGridView dgvResumenAsistenciaG1;
        private System.Windows.Forms.Label lblAlertasG1;
        private System.Windows.Forms.DataGridView dgvAlertasTardanzasG1;
        private System.Windows.Forms.Panel pnlAsistenciaG1;
        private System.Windows.Forms.Label lblPorcentajeAsistenciaG1;
        private System.Windows.Forms.Label lblAsistenciaTituloG1;
    }
}