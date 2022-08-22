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
    class ClsServicio
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_SERVICIO;
        private int _NUM_DETALLE_SERVICIO;
        private int _ESTADO;
        private string _SERVICIO;
        private int _TIPO;
        private double _PRECIO;

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

        public int NUM_DETALLE_SERVICIO
        {
            get
            {
                return _NUM_DETALLE_SERVICIO;
            }

            set
            {
                _NUM_DETALLE_SERVICIO = value;
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

        public string SERVICIO
        {
            get
            {
                return _SERVICIO;
            }

            set
            {
                _SERVICIO = value;
            }
        }

        public int TIPO
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

        public double PRECIO
        {
            get
            {
                return _PRECIO;
            }

            set
            {
                _PRECIO = value;
            }
        }
        public void INSERT_CAT_SERVICIOS()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_SERVICIOS";
                comand.Parameters.AddWithValue("@NUM_DETALLE_SERVICIO", NUM_DETALLE_SERVICIO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@SERVICIO", SERVICIO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@PRECIO", PRECIO);
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
        public void MODIFIC_CAT_SERVICIOS()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_CAT_SERVICIOS";
                comand.Parameters.AddWithValue("@NUM_SERVICIO", NUM_SERVICIO);
                comand.Parameters.AddWithValue("@NUM_DETALLE_SERVICIO", NUM_DETALLE_SERVICIO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@SERVICIO", SERVICIO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@PRECIO", PRECIO);
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
        public DataTable SELECT_CAT_SERVICIOS()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CAT_SERVICIOS";
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
        public void ELIMINAR_CAT_SERVICIOS()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CAT_SERVICIOS";
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
