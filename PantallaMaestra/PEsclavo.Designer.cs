namespace PantallaMaestra
{
    partial class FrmPEsclavo
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
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.dgv_esclavo = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txt_abono = new System.Windows.Forms.TextBox();
            this.lbl_abono = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_esclavo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cedula
            // 
            this.txt_cedula.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(51, 64);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(244, 24);
            this.txt_cedula.TabIndex = 1;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.Location = new System.Drawing.Point(47, 41);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(78, 19);
            this.lbl_cedula.TabIndex = 5;
            this.lbl_cedula.Text = "CEDULA";
            // 
            // dgv_esclavo
            // 
            this.dgv_esclavo.AllowUserToAddRows = false;
            this.dgv_esclavo.AllowUserToDeleteRows = false;
            this.dgv_esclavo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_esclavo.Location = new System.Drawing.Point(51, 143);
            this.dgv_esclavo.Name = "dgv_esclavo";
            this.dgv_esclavo.ReadOnly = true;
            this.dgv_esclavo.RowHeadersWidth = 51;
            this.dgv_esclavo.Size = new System.Drawing.Size(321, 208);
            this.dgv_esclavo.TabIndex = 7;
            this.dgv_esclavo.Visible = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar.FlatAppearance.BorderSize = 3;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(629, 41);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(147, 37);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "BUSCAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 3;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(629, 84);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(147, 37);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Visible = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Yellow;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_volver.FlatAppearance.BorderSize = 3;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(629, 358);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(147, 37);
            this.btn_volver.TabIndex = 17;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Silver;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cerrar.FlatAppearance.BorderSize = 3;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(629, 401);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(147, 37);
            this.btn_cerrar.TabIndex = 18;
            this.btn_cerrar.Text = "CERRAR SESION";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // txt_abono
            // 
            this.txt_abono.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_abono.Location = new System.Drawing.Point(333, 64);
            this.txt_abono.Name = "txt_abono";
            this.txt_abono.Size = new System.Drawing.Size(244, 24);
            this.txt_abono.TabIndex = 19;
            this.txt_abono.Visible = false;
            // 
            // lbl_abono
            // 
            this.lbl_abono.AutoSize = true;
            this.lbl_abono.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abono.Location = new System.Drawing.Point(329, 41);
            this.lbl_abono.Name = "lbl_abono";
            this.lbl_abono.Size = new System.Drawing.Size(68, 19);
            this.lbl_abono.TabIndex = 20;
            this.lbl_abono.Text = "ABONO";
            this.lbl_abono.Visible = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Gray;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_limpiar.FlatAppearance.BorderSize = 3;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(629, 127);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(147, 37);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.Gray;
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_reportes.FlatAppearance.BorderSize = 3;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.Location = new System.Drawing.Point(629, 315);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(147, 37);
            this.btn_reportes.TabIndex = 22;
            this.btn_reportes.Text = "IR A REPORTES";
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // FrmPEsclavo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.lbl_abono);
            this.Controls.Add(this.txt_abono);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_esclavo);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.txt_cedula);
            this.MaximizeBox = false;
            this.Name = "FrmPEsclavo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PANTALLA ESCLAVO";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_esclavo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.DataGridView dgv_esclavo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox txt_abono;
        private System.Windows.Forms.Label lbl_abono;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_reportes;
    }
}