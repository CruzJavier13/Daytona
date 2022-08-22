using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDato
{
    class ClsUsuario
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_USUARIO;
        private int _ESTADO;
        private int _EMPLEADO;
        private string _USUARIO;
        private string _CONTRASENA;
        private DateTime _FECHA_CUENTA;

        public int NUM_USUARIO
        {
            get
            {
                return _NUM_USUARIO;
            }

            set
            {
                _NUM_USUARIO = value;
            }
        }

        public int ESTADO
        {
            get
            {
                return _ESTADO;
            }

            set
            {
                _ESTADO = value;
            }
        }

        public int EMPLEADO
        {
            get
            {
                return _EMPLEADO;
            }

            set
            {
                _EMPLEADO = value;
            }
        }

        public string USUARIO
        {
            get
            {
                return _USUARIO;
            }

            set
            {
                _USUARIO = value;
            }
        }

        public string CONTRASENA
        {
            get
            {
                return _CONTRASENA;
            }

            set
            {
                _CONTRASENA = value;
            }
        }

        public DateTime FECHA_CUENTA
        {
            get
            {
                return _FECHA_CUENTA;
            }

            set
            {
                _FECHA_CUENTA = value;
            }
        }

        public void INSERT_TBL_USUARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_USUARIO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@EMPLEADO", EMPLEADO);
                comand.Parameters.AddWithValue("@USUARIO ", USUARIO);
                comand.Parameters.AddWithValue("@CONTRASENA", CONTRASENA);
                comand.Parameters.AddWithValue("@FECHA_CUENTA", FECHA_CUENTA);
                comand.CommandType = CommandType.StoredProcedure;

                comand.ExecuteNonQuery();
                comand.Connection = data.Close();
                comand.Parameters.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        public void MODIFIC_TBL_USUARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_USUARIO";
                comand.Parameters.AddWithValue("@NUM_USUARIO", NUM_USUARIO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@EMPLEADO", EMPLEADO);
                comand.Parameters.AddWithValue("@USUARIO ", USUARIO);
                comand.Parameters.AddWithValue("@CONTRASENA", CONTRASENA);
                comand.Parameters.AddWithValue("@FECHA_CUENTA", FECHA_CUENTA);
                comand.CommandType = CommandType.StoredProcedure;

                comand.ExecuteNonQuery();
                comand.Connection = data.Close();
                comand.Parameters.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        public DataTable SELECT_TBL_USUARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_USUARIO";
                comand.Parameters.AddWithValue("@NUM_USUARIO", NUM_USUARIO);
                comand.CommandType = CommandType.StoredProcedure;

                DataRead = comand.ExecuteReader();
                table.Load(DataRead);
                comand.Connection = data.Close();
                comand.Parameters.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            return table;
        }
        public void ELIMINAR_TBL_USUARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_USUARIO";
                comand.Parameters.AddWithValue("@NUM_USUARIO", NUM_USUARIO);
                comand.CommandType = CommandType.StoredProcedure;

                comand.ExecuteNonQuery();
                comand.Connection = data.Close();
                comand.Parameters.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
    }
}
