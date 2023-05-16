namespace PantallaMaestra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cedula
            // 
            this.txt_cedula.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(51, 64);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(244, 24);
            this.txt_cedula.TabIndex = 0;
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(342, 162);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(244, 24);
            this.txt_correo.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(342, 64);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(244, 24);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.Location = new System.Drawing.Point(51, 162);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(244, 24);
            this.txt_edad.TabIndex = 3;
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.Location = new System.Drawing.Point(48, 46);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(64, 15);
            this.lbl_cedula.TabIndex = 4;
            this.lbl_cedula.Text = "CEDULA";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(339, 46);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 15);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.Location = new System.Drawing.Point(48, 144);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(46, 15);
            this.lbl_edad.TabIndex = 6;
            this.lbl_edad.Text = "EDAD";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(339, 144);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(65, 15);
            this.lbl_correo.TabIndex = 7;
            this.lbl_correo.Text = "CORREO";
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crear.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_crear.FlatAppearance.BorderSize = 3;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.Location = new System.Drawing.Point(629, 12);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(147, 37);
            this.btn_crear.TabIndex = 8;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar.FlatAppearance.BorderSize = 3;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(629, 55);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(147, 37);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Visible = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_eliminar.FlatAppearance.BorderSize = 3;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(629, 98);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(147, 37);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Visible = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.Yellow;
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_consultar.FlatAppearance.BorderSize = 3;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(629, 141);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(147, 37);
            this.btn_consultar.TabIndex = 11;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(51, 237);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.Size = new System.Drawing.Size(725, 201);
            this.dgv_1.TabIndex = 12;
            this.dgv_1.Visible = false;
            this.dgv_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellClick);
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Gray;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_limpiar.FlatAppearance.BorderSize = 3;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(629, 184);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(147, 37);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_cedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

