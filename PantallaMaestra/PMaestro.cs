using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using Microsoft.Office.Interop.Excel;

namespace PantallaMaestra
{
    /// <summary>
    /// Esta es la pestaña de maestro donde el solo el admin puede aplicar CRUD con los usuarios.
    /// </summary>
    public partial class FrmPMaestro : Form
    {
        int cedula;
        string nombre;
        int edad;
        string correo;
        int error = 0;
        int cen = 0;

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

                if (edad <= 18 || edad > 100)
                {
                    error = 1;
                }
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
            btnExportartxt.Visible = true;
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
            if (cen == 0)
            {
                txt_cedula.ReadOnly = true;
                txt_nombre.ReadOnly = false;
                txt_edad.ReadOnly = false;
                txt_correo.ReadOnly = false;

                btn_editar.Text = "GUARDAR";

                cen = 1;
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

                    if (edad <= 18 || edad > 100)
                    {
                        error = 1;
                    }
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
                cen = 0;
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

                txt_cedula.ReadOnly = true;
                txt_nombre.ReadOnly = true;
                txt_edad.ReadOnly = true;
                txt_correo.ReadOnly = true;
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
            btn_consultar.Visible = true;
            btnExportartxt.Visible = false;

            txt_cedula.Visible = true;
            txt_nombre.Visible = true;
            txt_edad.Visible = true;
            txt_correo.Visible = true;

            dgv_1.Visible = false;
            dgv_2.Visible = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            FrmPEsclavo esclavo = new FrmPEsclavo();
            esclavo.Show();
            this.Hide();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de texto (*.txt)|*.txt";
            abrir.Title = "Seleccionar archivo de texto";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string nombre_archivo = abrir.FileName;

                string[] lineas = File.ReadAllLines(nombre_archivo);

                foreach (string line in lineas)
                {
                    string[] columnas = line.Split(';');

                    if (columnas.Length >= 4)
                    {
                        dgv_2.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3]);
                    }
                }
            }

            dgv_2.Visible = true;
            btn_consultar.Visible = false;
        }

        private void dgv_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_cedula.Text = dgv_2.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = dgv_2.CurrentRow.Cells[1].Value.ToString();
                txt_edad.Text = dgv_2.CurrentRow.Cells[2].Value.ToString();
                txt_correo.Text = dgv_2.CurrentRow.Cells[3].Value.ToString();

                txt_cedula.Visible = true;
                txt_nombre.Visible = true;
                txt_edad.Visible = true;
                txt_correo.Visible = true;

                btn_crear.Visible = true;

                txt_cedula.ReadOnly = false;
                txt_nombre.ReadOnly = false;
                txt_edad.ReadOnly = false;
                txt_correo.ReadOnly = false;
            }
            catch
            {

            }
        }


        private void btnExportartxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar como archivo de texto";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                // Agregar datos de las filas, omitiendo la primera fila
                for (int rowIndex = 0; rowIndex < dgv_1.Rows.Count; rowIndex++)
                {
                    DataGridViewRow fila = dgv_1.Rows[rowIndex];

                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (celda.Value != null)
                        {
                            sb.Append(celda.Value.ToString());
                        }
                        sb.Append(";");
                    }
                    sb.AppendLine();
                }

                // Guardar el contenido en el archivo seleccionado
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());

                MessageBox.Show("El archivo se ha exportado correctamente.", "Exportar a archivo de texto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
