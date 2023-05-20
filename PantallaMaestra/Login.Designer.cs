namespace PantallaMaestra
{
    partial class FrmLogin
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
            System.Windows.Forms.Label lblContraseña;
            System.Windows.Forms.Label lblCorreo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.gpnLogin = new System.Windows.Forms.GroupBox();
            this.lblLINK = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            lblContraseña = new System.Windows.Forms.Label();
            lblCorreo = new System.Windows.Forms.Label();
            this.gpnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new System.Drawing.Point(67, 207);
            lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new System.Drawing.Size(124, 19);
            lblContraseña.TabIndex = 10;
            lblContraseña.Text = "CONTRASEÑA:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new System.Drawing.Point(67, 151);
            lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new System.Drawing.Size(83, 19);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "CORREO:";
            // 
            // gpnLogin
            // 
            this.gpnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpnLogin.Controls.Add(this.lblLINK);
            this.gpnLogin.Controls.Add(this.btnEntrar);
            this.gpnLogin.Controls.Add(this.pictureBox1);
            this.gpnLogin.Controls.Add(lblContraseña);
            this.gpnLogin.Controls.Add(this.txtContraseña);
            this.gpnLogin.Controls.Add(lblCorreo);
            this.gpnLogin.Controls.Add(this.txtCorreo);
            this.gpnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpnLogin.Location = new System.Drawing.Point(140, 10);
            this.gpnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpnLogin.Name = "gpnLogin";
            this.gpnLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpnLogin.Size = new System.Drawing.Size(321, 375);
            this.gpnLogin.TabIndex = 2;
            this.gpnLogin.TabStop = false;
            this.gpnLogin.Text = "LOGIN";
            // 
            // lblLINK
            // 
            this.lblLINK.AutoSize = true;
            this.lblLINK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLINK.Location = new System.Drawing.Point(70, 317);
            this.lblLINK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLINK.Name = "lblLINK";
            this.lblLINK.Size = new System.Drawing.Size(67, 19);
            this.lblLINK.TabIndex = 14;
            this.lblLINK.TabStop = true;
            this.lblLINK.Text = "Registro";
            this.lblLINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLINK_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(70, 278);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(186, 29);
            this.btnEntrar.TabIndex = 13;
            this.btnEntrar.Text = "INGRESAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(69, 228);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(187, 26);
            this.txtContraseña.TabIndex = 11;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(70, 172);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(187, 26);
            this.txtCorreo.TabIndex = 9;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 390);
            this.Controls.Add(this.gpnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.gpnLogin.ResumeLayout(false);
            this.gpnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpnLogin;
        private System.Windows.Forms.LinkLabel lblLINK;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}