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
    /// Esta es la pantalla principal con todos los mecanismos de crear, editar, eliminar, y consultar a la
    /// base de datos(sql server)
    /// </summary>
    public partial class FrmPMaestro : Form
    {
        int cedula;
        string nombre;
        int edad;
        string correo;
        int error = 0;

        public FrmPMaestro()
        {
            InitializeComponent();

            Conexion co = new Conexion();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            bool resultado = false;

            try
            {
                cedula = int.Parse(txt_cedula.Text);
            }
            catch (Exception ex)
            {
                error = 1;
            }

            try
            {
                nombre = txt_nombre.Text;
            }
            catch (Exception ex)
            {
                error = 1;
            }

            try
            {
                edad = int.Parse(txt_edad.Text);
            }
            catch (Exception ex)
            {
                error = 1;
            }

            try
            {
                correo = txt_correo.Text;
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

                        txt_cedula.Clear();
                        txt_nombre.Clear();
                        txt_edad.Clear();
                        txt_correo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El dato no ha podido ser registrado, vuelva a intentarlo.", "Mensaje",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                Conexion cnx = new Conexion();
                dgv_1.DataSource = cnx.vertabla();
                btn_editar.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_MaestroDataSet.tbl_persona' Puede moverla o quitarla según sea necesario.
            this.tbl_personaTableAdapter.Fill(this.db_MaestroDataSet.tbl_persona);

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            txt_cedula.ReadOnly = true;
            txt_nombre.ReadOnly = true;
            txt_edad.ReadOnly = true;
            txt_correo.ReadOnly = true;

            txt_cedula.Visible = false;
            txt_nombre.Visible = false;
            txt_edad.Visible = false;
            txt_correo.Visible = false;

            btn_crear.Visible = false;

            Conexion con = new Conexion();

            dgv_1.DataSource = con.vertabla();

            dgv_1.Visible = true;
        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_cedula.Text = dgv_1.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dgv_1.CurrentRow.Cells[1].Value.ToString();
                txt_edad.Text = dgv_1.CurrentRow.Cells[2].Value.ToString();
                txt_correo.Text = dgv_1.CurrentRow.Cells[3].Value.ToString();

                btn_editar.Visible = true;
                btn_eliminar.Visible = true;
            }
            catch
            {
                
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_cedula.ReadOnly == true)
            {
                txt_cedula.ReadOnly = false;
                txt_nombre.ReadOnly = false;
                txt_edad.ReadOnly = false;
                txt_correo.ReadOnly = false;

                btn_editar.Text = "GUARDAR";
                btn_crear.Visible = true;
            }
            else
            {
                bool resultado = false;

                try
                {
                    cedula = int.Parse(txt_cedula.Text);
                }
                catch (Exception ex)
                {
                    error = 1;
                }

                try
                {
                    nombre = txt_nombre.Text;
                }
                catch (Exception ex)
                {
                    error = 1;
                }

                try
                {
                    edad = int.Parse(txt_edad.Text);
                }
                catch (Exception ex)
                {
                    error = 1;
                }

                try
                {
                    correo = txt_correo.Text;
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
                    DialogResult r = MessageBox.Show("Esta seguro que desea editar el dato con cedula(" + cedula + ")," +
                        " nombre(" + nombre + "), edad(" + edad + "), correo(" + correo + ")????", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        Conexion cx = new Conexion();
                        resultado = cx.editar(cedula, nombre, edad, correo);

                        if (resultado == true)
                        {
                            MessageBox.Show("Dato editado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.None);

                            txt_cedula.Clear();
                            txt_nombre.Clear();
                            txt_edad.Clear();
                            txt_correo.Clear();

                            btn_editar.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("El dato no ha podido ser editado, vuelva a intentarlo.", "Mensaje",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                Conexion con = new Conexion();
                dgv_1.DataSource = con.vertabla();

                btn_editar.Text = "EDITAR";
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            bool resultado = false;

            try
            {
                cedula = int.Parse(txt_cedula.Text);
            }
            catch
            {
                
            }

            DialogResult r = MessageBox.Show("Esta seguro que desea eliminar el dato con cedula(" + cedula + ")????",
                "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Conexion cx = new Conexion();
                resultado = cx.Eliminar(cedula);

                if (resultado == true)
                {
                    MessageBox.Show("Dato eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.None);

                    txt_cedula.Clear();
                    txt_nombre.Clear();
                    txt_edad.Clear();
                    txt_correo.Clear();

                }
                else
                {
                    MessageBox.Show("El dato no ha podido ser eliminado, vuelva a intentarlo.", "Mensaje",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            dgv_1.DataSource = con.vertabla();
        }

        private void dgv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_cedula.Text = dgv_1.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dgv_1.CurrentRow.Cells[1].Value.ToString();
                txt_edad.Text = dgv_1.CurrentRow.Cells[2].Value.ToString();
                txt_correo.Text = dgv_1.CurrentRow.Cells[3].Value.ToString();

                txt_cedula.Visible = true;
                txt_nombre.Visible = true;
                txt_edad.Visible = true;
                txt_correo.Visible = true;

                btn_editar.Visible = true;
                btn_eliminar.Visible = true;
                btn_crear.Visible = false;
            }
            catch
            {

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cedula.Clear();
            txt_nombre.Clear();
            txt_edad.Clear();
            txt_correo.Clear();

            txt_cedula.ReadOnly = false;
            txt_nombre.ReadOnly = false;
            txt_edad.ReadOnly = false;
            txt_correo.ReadOnly = false;

            btn_crear.Visible = true;
            btn_editar.Visible = false;
            btn_eliminar.Visible = false;

            txt_cedula.Visible = true;
            txt_nombre.Visible = true;
            txt_edad.Visible = true;
            txt_correo.Visible = true;

            dgv_1.Visible = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
