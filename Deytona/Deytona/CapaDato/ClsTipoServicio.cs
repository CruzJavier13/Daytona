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
    class ClsTipoServicio
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_SERVICIO;
        private int _ESTADO;
        private string _TIPO;
        private string _DESCRIPCION;

        public int NUM_SERVICIO
        {
            get
            {
                return _NUM_SERVICIO;
            }

            set
            {
                _NUM_SERVICIO = value;
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

        public string TIPO
        {
            get
            {
                return _TIPO;
            }

            set
            {
                _TIPO = value;
            }
        }

        public string DESCRIPCION
        {
            get
            {
                return _DESCRIPCION;
            }

            set
            {
                _DESCRIPCION = value;
            }
        }
        public void INSERT_TIPO_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TIPO_SERVICIO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
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
        public void MODIFIC_TIPO_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TIPO_SERVICIO";
                comand.Parameters.AddWithValue("@NUM_SERVICIO", NUM_SERVICIO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
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
        public DataTable SP_SELECT_TIPO_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INICIAR_SESION";
                comand.Parameters.AddWithValue("@NUM_SERVICIO", NUM_SERVICIO);
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
        public void ELIMINAR_TIPO_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TIPO_SERVICIO";
                comand.Parameters.AddWithValue("@NUM_SERVICIO", NUM_SERVICIO);
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
