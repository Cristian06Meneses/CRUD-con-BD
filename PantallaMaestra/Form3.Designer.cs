namespace PantallaMaestra
{
    partial class Form3
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
            System.Windows.Forms.Label lblCedula;
            System.Windows.Forms.Label lblCorreo;
            System.Windows.Forms.Label lblNombre;
            System.Windows.Forms.Label lblEdad;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLINK = new System.Windows.Forms.LinkLabel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            lblCedula = new System.Windows.Forms.Label();
            lblCorreo = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblEdad = new System.Windows.Forms.Label();
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new System.Drawing.Point(67, 207);
            lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new System.Drawing.Size(79, 19);
            lblCedula.TabIndex = 10;
            lblCedula.Text = "CEDULA:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new System.Drawing.Point(66, 313);
            lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(83, 19);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "CORREO:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(67, 158);
            lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(87, 19);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new System.Drawing.Point(67, 261);
            lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new System.Drawing.Size(59, 19);
            lblEdad.TabIndex = 17;
            lblEdad.Text = "EDAD:";
            // 
            // grpRegistro
            // 
            this.grpRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpRegistro.Controls.Add(lblEdad);
            this.grpRegistro.Controls.Add(this.txtEdad);
            this.grpRegistro.Controls.Add(lblNombre);
            this.grpRegistro.Controls.Add(this.txtNombre);
            this.grpRegistro.Controls.Add(this.lblLINK);
            this.grpRegistro.Controls.Add(this.btnRegistrar);
            this.grpRegistro.Controls.Add(this.img1);
            this.grpRegistro.Controls.Add(lblCedula);
            this.grpRegistro.Controls.Add(this.txtCedula);
            this.grpRegistro.Controls.Add(lblCorreo);
            this.grpRegistro.Controls.Add(this.txtCorreo);
            this.grpRegistro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistro.Location = new System.Drawing.Point(240, 38);
            this.grpRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegistro.Size = new System.Drawing.Size(321, 451);
            this.grpRegistro.TabIndex = 3;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "REGISTRO";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(69, 282);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(187, 26);
            this.txtEdad.TabIndex = 18;
            this.txtEdad.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 179);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 26);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.UseSystemPasswordChar = true;
            // 
            // lblLINK
            // 
            this.lblLINK.AutoSize = true;
            this.lblLINK.Location = new System.Drawing.Point(113, 425);
            this.lblLINK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLINK.Name = "lblLINK";
            this.lblLINK.Size = new System.Drawing.Size(100, 19);
            this.lblLINK.TabIndex = 14;
            this.lblLINK.TabStop = true;
            this.lblLINK.Text = "Iniciar Sesión";
            this.lblLINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLINK_LinkClicked);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(71, 383);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(186, 29);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // img1
            // 
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(117, 32);
            this.img1.Margin = new System.Windows.Forms.Padding(2);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(76, 93);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 12;
            this.img1.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(69, 228);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(187, 26);
            this.txtCedula.TabIndex = 11;
            this.txtCedula.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(69, 334);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 26);
            this.txtCorreo.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.grpRegistro);
            this.Name = "Form3";
            this.Text = "Form3";
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.LinkLabel lblLINK;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
    }
}