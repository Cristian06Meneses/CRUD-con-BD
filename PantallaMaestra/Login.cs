using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaMaestra
{
    public partial class FrmLogin : Form
    {
        string correo = "";
        int cedula = 0;
        bool error = true;
        int contador = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool entrar = false;

            try
            {
                cedula = int.Parse(txtContraseña.Text);
            }
            catch (Exception ex)
            {
                error = false;
            }

            try
            {
                correo = txtCorreo.Text;
            }
            catch (Exception ex)
            {
                error = false;
            }

            if (error == true)
            {
                Conexion c = new Conexion();
                entrar = c.Verificar(txtCorreo.Text, txtContraseña.Text);

                if (entrar == true)
                {
                    MessageBox.Show("Usuario ingresado correctamente :D");

                    contador = 0;

                    txtCorreo.Clear();
                    txtContraseña.Clear();
                }
                else
                {
                    contador = contador + 1;
                    MessageBox.Show("Usuario o contraseña incorrectos D:",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (contador == 3)
                {
                    MessageBox.Show("Has excedido el numero de intentos D:");

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos, digite su correo y su cedula",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblLINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
