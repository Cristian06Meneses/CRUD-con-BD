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
    public partial class FrmPEsclavo : Form
    {
        /// <summary>
        /// Aqui estan todos los comandos de la Pantalla Maestro/Esclavo la cual solo me muestra los abonos
        /// hechos por la persona buscada. Esta pestaña solo la ve el administrador.
        /// </summary>
        public FrmPEsclavo()
        {
            InitializeComponent();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int cedula = 0;
            bool error = false;

            try
            {
                cedula = int.Parse(txt_cedula.Text);

                try
                {
                    Conexion cn = new Conexion();

                    error = cn.verif_esclavo(cedula);

                    if (error == false)
                    {
                        Conexion con = new Conexion();

                        dgv_esclavo.DataSource = con.tablaesclavo(cedula);

                        dgv_esclavo.Visible = true;
                        lbl_abono.Visible = true;
                        txt_abono.Visible = true;
                        txt_cedula.ReadOnly = true;
                        btn_agregar.Visible = true;
                        btn_editar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe verifique la cedula.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el usuario.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                error = true;

                MessageBox.Show("Dato incorrecto, recuerde que cedula debe ser numerico.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int cedula = 0;
            int abono = 0;
            bool error = false;
            bool agregado = false;

            try
            {
                cedula = int.Parse(txt_cedula.Text);
            }
            catch (Exception ex)
            {
                error = true;
            }

            try
            {
                abono = int.Parse(txt_abono.Text);

                if (abono <= 0)
                {
                    error = true;
                }
            }
            catch (Exception ex)
            {
                error = true;
            }

            if (error == false)
            {
                Conexion conex = new Conexion();
                agregado = conex.agregar_esclavo(cedula, abono);

                if (agregado == true)
                {
                    MessageBox.Show("Dato registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.None);

                    txt_abono.Clear();

                    Conexion con = new Conexion();

                    dgv_esclavo.DataSource = con.tablaesclavo(cedula);
                }
                else
                {
                    MessageBox.Show("El dato no ha podido ser registrado, vuelva a intentarlo.", "Mensaje",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dato incorrecto, recuerde que abono debe ser numerico y mayor a 0.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = true;
            btn_agregar.Visible = false;
            dgv_esclavo.Visible = false;

            txt_cedula.Clear();
            txt_abono.Clear();

            txt_abono.Visible = false;
            lbl_abono.Visible = false;

            txt_cedula.ReadOnly = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            FrmPMaestro maestro = new FrmPMaestro();
            maestro.Show();
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
