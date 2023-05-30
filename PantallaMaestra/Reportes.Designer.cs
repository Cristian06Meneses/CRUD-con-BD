namespace PantallaMaestra
{
    partial class FrmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblAbono2 = new System.Windows.Forms.Label();
            this.lblAbono1 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtAbono2 = new System.Windows.Forms.TextBox();
            this.txtAbono1 = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dgv_Reporte = new System.Windows.Forms.DataGridView();
            this.btnExportartxt = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(484, 71);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(89, 15);
            this.lblFechaFinal.TabIndex = 31;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(266, 71);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(98, 15);
            this.lblFechaInicio.TabIndex = 30;
            this.lblFechaInicio.Text = "Fecha Inicial";
            // 
            // lblAbono2
            // 
            this.lblAbono2.AutoSize = true;
            this.lblAbono2.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono2.Location = new System.Drawing.Point(484, 23);
            this.lblAbono2.Name = "lblAbono2";
            this.lblAbono2.Size = new System.Drawing.Size(96, 15);
            this.lblAbono2.TabIndex = 29;
            this.lblAbono2.Text = "Abono hasta";
            // 
            // lblAbono1
            // 
            this.lblAbono1.AutoSize = true;
            this.lblAbono1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono1.Location = new System.Drawing.Point(266, 24);
            this.lblAbono1.Name = "lblAbono1";
            this.lblAbono1.Size = new System.Drawing.Size(98, 15);
            this.lblAbono1.TabIndex = 28;
            this.lblAbono1.Text = "Abono desde";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(57, 40);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(58, 15);
            this.lblCedula.TabIndex = 27;
            this.lblCedula.Text = "Cedula";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(487, 90);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(102, 22);
            this.dtpFechaFinal.TabIndex = 26;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(268, 90);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(108, 22);
            this.dtpFechaInicio.TabIndex = 25;
            // 
            // txtAbono2
            // 
            this.txtAbono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono2.Location = new System.Drawing.Point(487, 40);
            this.txtAbono2.Name = "txtAbono2";
            this.txtAbono2.Size = new System.Drawing.Size(176, 22);
            this.txtAbono2.TabIndex = 24;
            // 
            // txtAbono1
            // 
            this.txtAbono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono1.Location = new System.Drawing.Point(268, 40);
            this.txtAbono1.Name = "txtAbono1";
            this.txtAbono1.Size = new System.Drawing.Size(176, 22);
            this.txtAbono1.TabIndex = 23;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Khaki;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(494, 138);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(169, 37);
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "GENERAR REPORTE";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(60, 60);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(138, 22);
            this.txtCedula.TabIndex = 21;
            // 
            // dgv_Reporte
            // 
            this.dgv_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reporte.Location = new System.Drawing.Point(12, 138);
            this.dgv_Reporte.Name = "dgv_Reporte";
            this.dgv_Reporte.RowHeadersWidth = 51;
            this.dgv_Reporte.Size = new System.Drawing.Size(456, 141);
            this.dgv_Reporte.TabIndex = 20;
            // 
            // btnExportartxt
            // 
            this.btnExportartxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExportartxt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportartxt.Location = new System.Drawing.Point(12, 284);
            this.btnExportartxt.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportartxt.Name = "btnExportartxt";
            this.btnExportartxt.Size = new System.Drawing.Size(141, 38);
            this.btnExportartxt.TabIndex = 32;
            this.btnExportartxt.Text = "EXPORTAR A TXT";
            this.btnExportartxt.UseVisualStyleBackColor = false;
            this.btnExportartxt.Visible = false;
            this.btnExportartxt.Click += new System.EventHandler(this.btnExportartxt_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Silver;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_volver.FlatAppearance.BorderSize = 3;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(494, 284);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(169, 37);
            this.btn_volver.TabIndex = 33;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Silver;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_limpiar.FlatAppearance.BorderSize = 3;
            this.btn_limpiar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(494, 181);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(169, 37);
            this.btn_limpiar.TabIndex = 34;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 333);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btnExportartxt);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblAbono2);
            this.Controls.Add(this.lblAbono1);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtAbono2);
            this.Controls.Add(this.txtAbono1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.dgv_Reporte);
            this.MaximizeBox = false;
            this.Name = "FrmReportes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblAbono2;
        private System.Windows.Forms.Label lblAbono1;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtAbono2;
        private System.Windows.Forms.TextBox txtAbono1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridView dgv_Reporte;
        private System.Windows.Forms.Button btnExportartxt;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_limpiar;
    }
}