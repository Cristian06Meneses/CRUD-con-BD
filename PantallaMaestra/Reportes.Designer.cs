namespace PantallaMaestra
{
    partial class Reportes
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(541, 88);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(117, 20);
            this.lblFechaFinal.TabIndex = 31;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(250, 88);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(129, 20);
            this.lblFechaInicio.TabIndex = 30;
            this.lblFechaInicio.Text = "Fecha Inicial";
            // 
            // lblAbono2
            // 
            this.lblAbono2.AutoSize = true;
            this.lblAbono2.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono2.Location = new System.Drawing.Point(541, 30);
            this.lblAbono2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbono2.Name = "lblAbono2";
            this.lblAbono2.Size = new System.Drawing.Size(124, 20);
            this.lblAbono2.TabIndex = 29;
            this.lblAbono2.Text = "Abono hasta";
            // 
            // lblAbono1
            // 
            this.lblAbono1.AutoSize = true;
            this.lblAbono1.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono1.Location = new System.Drawing.Point(250, 31);
            this.lblAbono1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbono1.Name = "lblAbono1";
            this.lblAbono1.Size = new System.Drawing.Size(126, 20);
            this.lblAbono1.TabIndex = 28;
            this.lblAbono1.Text = "Abono desde";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(5, 58);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(75, 20);
            this.lblCedula.TabIndex = 27;
            this.lblCedula.Text = "Cedula";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(545, 112);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(135, 26);
            this.dtpFechaFinal.TabIndex = 26;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(254, 112);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(143, 26);
            this.dtpFechaInicio.TabIndex = 25;
            // 
            // txtAbono2
            // 
            this.txtAbono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono2.Location = new System.Drawing.Point(545, 50);
            this.txtAbono2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAbono2.Name = "txtAbono2";
            this.txtAbono2.Size = new System.Drawing.Size(233, 26);
            this.txtAbono2.TabIndex = 24;
            // 
            // txtAbono1
            // 
            this.txtAbono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono1.Location = new System.Drawing.Point(254, 50);
            this.txtAbono1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAbono1.Name = "txtAbono1";
            this.txtAbono1.Size = new System.Drawing.Size(233, 26);
            this.txtAbono1.TabIndex = 23;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(13, 337);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(183, 46);
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(9, 82);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(183, 26);
            this.txtCedula.TabIndex = 21;
            // 
            // dgv_Reporte
            // 
            this.dgv_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reporte.Location = new System.Drawing.Point(9, 155);
            this.dgv_Reporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Reporte.Name = "dgv_Reporte";
            this.dgv_Reporte.RowHeadersWidth = 51;
            this.dgv_Reporte.Size = new System.Drawing.Size(589, 174);
            this.dgv_Reporte.TabIndex = 20;
            // 
            // btnExportartxt
            // 
            this.btnExportartxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExportartxt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportartxt.Location = new System.Drawing.Point(410, 336);
            this.btnExportartxt.Name = "btnExportartxt";
            this.btnExportartxt.Size = new System.Drawing.Size(188, 46);
            this.btnExportartxt.TabIndex = 32;
            this.btnExportartxt.Text = "EXPORTAR A TXT";
            this.btnExportartxt.UseVisualStyleBackColor = false;
            this.btnExportartxt.Visible = false;
            this.btnExportartxt.Click += new System.EventHandler(this.btnExportartxt_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 407);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Reportes";
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
    }
}