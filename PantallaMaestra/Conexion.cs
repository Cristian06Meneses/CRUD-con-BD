using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PantallaMaestra
{
    /// <summary>
    /// Esta es la clase de conexion la cual conecta el programa con la base de datos en sql server y me hace los
    /// procesos que tengan que ver con ella como registro, creacion, eliminacion, edicion, y
    /// toma de toda la tabla
    /// </summary>
    internal class Conexion
    {
        SqlConnection conec;
        SqlCommand cmd;
        SqlDataReader dr_lector;

        public Conexion()
        {
            try
            {
                conec = new SqlConnection("Data Source=.;Initial Catalog=db_Maestro;Integrated Security=True");
                conec.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion: " + ex.ToString());
            }

        }

        public bool Registrar(int cedula, string nombre, int edad, string correo)
        {
            bool r = false;
            string query = "insert into tbl_persona values( " + cedula + ", '" + nombre + "', " + edad + ", '" + correo + "')";
            cmd = new SqlCommand(query, conec);

            try
            {
                cmd.ExecuteReader();

                r = true;
            }
            catch (Exception ex)
            {
                r = false;
            }

            return r;
        }

        public DataTable vertabla()
        {
            DataTable tablas = new DataTable();
            string query = " Select * from tbl_persona";
            cmd = new SqlCommand(query, conec);

            SqlDataAdapter data = new SqlDataAdapter(cmd);

            data.Fill(tablas);

            return tablas;
        }

        public bool editar(int cedula, string nombre, int edad, string correo)
        {
            bool r = false;
            string query = "update tbl_persona set cedula = " + cedula + ", nombre = '" + nombre + "', edad = " + edad + ", correo = '" + correo + "'";
            cmd = new SqlCommand(query, conec);

            try
            {
                cmd.ExecuteReader();

                r = true;
            }
            catch (Exception ex)
            {
                r = false;
            }

            return r;
        }

        public bool Eliminar(int cedula)
        {
            bool r = false;
            string query = "delete from tbl_persona where cedula = " + cedula + "";
            cmd = new SqlCommand(query, conec);

            try
            {
                cmd.ExecuteReader();

                r = true;
            }
            catch (Exception ex)
            {
                r = false;
            }

            return r;
        }
    }
}
