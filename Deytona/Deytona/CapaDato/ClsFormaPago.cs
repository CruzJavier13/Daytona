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
    class ClsFormaPago
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_PAGO;
        private int _ESTADO;
        private string _NOMBRE;

        public int NUM_PAGO
        {
            get
            {
                return _NUM_PAGO;
            }

            set
            {
                _NUM_PAGO = value;
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

        public string NOMBRE
        {
            get
            {
                return _NOMBRE;
            }

            set
            {
                _NOMBRE = value;
            }
        }
        public void INSERT_CAT_FORMA_PAGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_FORMA_PAGO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NOMBRE", NOMBRE);
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
        public void MODIFIC_CAT_FORMA_PAGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_CAT_FORMA_PAGO";
                comand.Parameters.AddWithValue("@NUM_PAGO", NUM_PAGO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NOMBRE", NOMBRE);
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
        public DataTable SELECT_CAT_FORMA_PAGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CAT_FORMA_PAGO";
                comand.Parameters.AddWithValue("@NUM_PAGO", NUM_PAGO);
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
        public void ELIMINAR_CAT_FORMA_PAGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CAT_FORMA_PAGO";
                comand.Parameters.AddWithValue("@NUM_PAGO", NUM_PAGO);
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
