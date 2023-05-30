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
    /// Esta es la clase de conexion la cual conecta el programa con la base de datos en sql server
    /// y hace los procesos que tengan que ver con la base de datos.
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

        public bool Verificar(string correo, string cedula)
        {
            bool resultado = false;
            string query = "Select correo, cedula from tbl_persona where correo = '" + correo + "' and cedula = " + cedula + "";

            cmd = new SqlCommand(query, conec);

            dr_lector = cmd.ExecuteReader();
            bool entrar = dr_lector.HasRows;

            if (entrar)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
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

        public DataTable tablaesclavo(int cedula)
        {
            DataTable tablas = new DataTable();
            string query = " Select abono, fecha from tbl_esclavo where cedula = " + cedula + "";
            cmd = new SqlCommand(query, conec);

            SqlDataAdapter data = new SqlDataAdapter(cmd);

            data.Fill(tablas);

            return tablas;
        }

        public bool verif_esclavo(int cedula)
        {
            bool existe = false;
            string query = "select cedula from tbl_persona where cedula = " + cedula + "";

            cmd = new SqlCommand(query, conec);

            dr_lector = cmd.ExecuteReader();
            bool entrar = dr_lector.HasRows;

            if (entrar)
            {
                existe = false;
            }
            else
            {
                existe = true;
            }

            return existe;
        }

        public bool agregar_esclavo(int cedula, int abono)
        {
            bool agregado = false;
            string query = "insert into tbl_esclavo values(" + cedula + ", " + abono + ", getdate())";
            cmd = new SqlCommand(query, conec);

            try
            {
                cmd.ExecuteReader();

                agregado = true;
            }
            catch (Exception ex)
            {
                agregado = false;
            }

            return agregado;
        }
        // query para los reportes
        public DataTable Reporte(string codigo)
        {
            DataTable tabla = new DataTable();

            string query = "SELECT tbl_esclavo.abono FROM tbl_esclavo " + codigo;
            SqlCommand command = new SqlCommand(query, conec);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(tabla);

            return tabla;
        }


    }
}
