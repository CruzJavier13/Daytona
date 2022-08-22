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
    public class ClsCargo
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_CARGO;
        private int _ESTADO;
        private string _CARGO;

        public int NUM_CARGO
        {
            get
            {
                return _NUM_CARGO;
            }

            set
            {
                _NUM_CARGO = value;
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

        public string CARGO
        {
            get
            {
                return _CARGO;
            }

            set
            {
                _CARGO = value;
            }
        }
        public void INSERT_CARGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CARGO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@CARGO", CARGO);
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
        public void MODIFIC_CARGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_CARGO";
                comand.Parameters.AddWithValue("@NUM_CARGO", NUM_CARGO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@CARGO", CARGO);
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
        public DataTable SELECT_CARGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CARGO";
                comand.Parameters.AddWithValue("@NUM_CARGO", NUM_CARGO);
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
        public void ELIMINAR_CARGO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CARGO";
                comand.Parameters.AddWithValue("@NUM_CARGO", NUM_CARGO);
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
