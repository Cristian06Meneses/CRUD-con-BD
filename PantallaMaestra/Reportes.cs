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

namespace PantallaMaestra
{
    public partial class FrmReportes : Form
    {
        Conexion conexion = new Conexion();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            int cedula = 0;
            int abono = 0;
            int abono2 = 0;
            string codigo = "";
            bool abonos = true;

            DateTime fecha1 = dtpFechaInicio.Value;
            DateTime fecha2 = dtpFechaFinal.Value;
            string fechaInicio = dtpFechaInicio.Text;
            string fechaFinal = dtpFechaFinal.Text;
            int abonovalor = 0;
            int abonovalor2 = 0;

            try
            {
                abonovalor = int.Parse(txtAbono1.Text);

                try
                {
                    abonovalor2 = int.Parse(txtAbono2.Text);

                    if (abonovalor >= abonovalor2)
                    {
                        abonos = false;
                    }
                }
                catch (Exception ex)
                {
                    abonos = true;
                }
            }
            catch(Exception ex)
            {
                abonos = true;
            }

            if (fecha1 < fecha2 && abonos == true)
            {
                if (txtCedula.Text == "")
                {
                    if (txtAbono1.Text == "")
                    {
                        if (txtAbono2.Text == "")
                        {
                            codigo = "where tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;

                        }
                        else
                        {
                            try
                            {
                                abono2 = int.Parse(txtAbono2.Text);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("error: verifique el Abono 2 (ingrese valores enteros)");

                            }

                            codigo = "where tbl_esclavo.abono<=" + abono2 + " and tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;

                        }

                    }
                    else
                    {
                        try
                        {
                            abono = int.Parse(txtAbono1.Text);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error: verifique el Abono 1 (ingrese valores enteros)");

                        }
                        if (txtAbono2.Text == "")
                        {
                            codigo = "where tbl_esclavo.abono>=" + abono + " and tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;
                        }
                        else
                        {
                            try
                            {
                                abono2 = int.Parse(txtAbono2.Text);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("error: verifique el Abono 2 (ingrese valores enteros)");

                            }

                            codigo = "where tbl_esclavo.abono>=" + abono + "and tbl_esclavo.abono<=" + abono2 + " and tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;
                        }
                    }
                }
                // 
                else
                {
                    try
                    {
                        cedula = int.Parse(txtCedula.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: verifique la cédula (ingrese valores enteros)");

                    }
                    if (txtAbono1.Text == "")
                    {
                        if (txtAbono2.Text == "")
                        {
                            codigo = "where tbl_esclavo.cedula=" + cedula + " and tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;

                        }
                        else
                        {
                            try
                            {
                                abono2 = int.Parse(txtAbono2.Text);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("error: verifique el Abono 2 (ingrese valores enteros)");

                            }

                            codigo = "where tbl_esclavo.abono<= " + abono2 + " and tbl_esclavo.cedula=" + cedula + " and tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;

                        }

                    }
                    else
                    {
                        try
                        {
                            abono = int.Parse(txtAbono1.Text);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error: verifique el Abono 1 (ingrese valores enteros)");

                        }
                        if (txtAbono2.Text == "")
                        {
                            codigo = "where tbl_esclavo.abono>=" + abono + " and tbl_esclavo.cedula= " + cedula + " and tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;
                        }
                        else
                        {
                            try
                            {
                                abono2 = int.Parse(txtAbono2.Text);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("error: verifique el Abono 2 (ingrese valores enteros)");

                            }

                            codigo = "where tbl_esclavo.cedula=" + cedula + " and tbl_esclavo.abono>=" + abono + "and tbl_esclavo.abono<=" + abono2 + " and tbl_esclavo.fecha>='" + fechaInicio + "' and tbl_esclavo.fecha<='" + fechaFinal + "'";
                            DataTable tabla1 = new DataTable();
                            tabla1 = conexion.Reporte(codigo);
                            dgv_Reporte.DataSource = tabla1;
                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("la fecha 1 debe ser menor a la fecha dos y el valor de abono 1 debe ser menor a abono 2 o vacios");
            }

            btnExportartxt.Visible = true;
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
                for (int rowIndex = 0; rowIndex < dgv_Reporte.Rows.Count; rowIndex++)
                {
                    DataGridViewRow fila = dgv_Reporte.Rows[rowIndex];

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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            FrmPEsclavo esclavo = new FrmPEsclavo();
            esclavo.Show();
            this.Hide();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtAbono1.Clear();
            txtAbono2.Clear();

            btnExportartxt.Visible = false;
        }
    }
}
