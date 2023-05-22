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
    /// <summary>
    /// Esta es la pestaña de registro donde los nuevos usuarios pueden registrarse.
    /// </summary>
    public partial class FrmRegistro : Form
    {
        int cedula;
        string nombre;
        int edad;
        string correo;
        int error = 0;
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool resultado = false;

            try
            {
                cedula = int.Parse(txtCedula.Text);
            }
            catch (Exception ex)
            {
                error = 1;
            }

            try
            {
                nombre = txtNombre.Text;
            }
            catch (Exception ex)
            {
                error = 1;
            }

            try
            {
                edad = int.Parse(txtEdad.Text);
            }
            catch (Exception ex)
            {
                error = 1;
            }

            try
            {
                correo = txtCorreo.Text;
            }
            catch (Exception ex)
            {
                error = 1;
            }

            if (error == 1)
            {
                MessageBox.Show("Alguno de los datos es incorrecto, recuerde que cedula y edad deben ser numericos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                error = 0;
            }
            else
            {
                DialogResult r = MessageBox.Show("Esta seguro que desea ingresar el dato con cedula(" + cedula + ")," +
                    " nombre(" + nombre + "), edad(" + edad + "), correo(" + correo + ")????", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    Conexion cx = new Conexion();
                    resultado = cx.Registrar(cedula, nombre, edad, correo);

                    if (resultado == true)
                    {
                        MessageBox.Show("Dato registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.None);

                        txtCedula.Clear();
                        txtNombre.Clear();
                        txtEdad.Clear();
                        txtCorreo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El dato no ha podido ser registrado, vuelva a intentarlo.", "Mensaje",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                Conexion cnx = new Conexion();
            }
        }

        private void lblLINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
