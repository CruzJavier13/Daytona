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
   public class ClsVehiculoCliente
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_VEHICULO;
        private int _ESTADO;
        private string _MARCA;
        private string _PLACA;
        private string _CATEGORIA;

        public int NUM_VEHICULO
        {
            get
            {
                return _NUM_VEHICULO;
            }

            set
            {
                _NUM_VEHICULO = value;
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

        public string MARCA
        {
            get
            {
                return _MARCA;
            }

            set
            {
                _MARCA = value;
            }
        }

        public string PLACA
        {
            get
            {
                return _PLACA;
            }

            set
            {
                _PLACA = value;
            }
        }

        public string CATEGORIA
        {
            get
            {
                return _CATEGORIA;
            }

            set
            {
                _CATEGORIA = value;
            }
        }
        public void INSERT_TBL_VEHICULO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_VEHICULO_CLIENTE";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@MARCA", MARCA);
                comand.Parameters.AddWithValue("@PLACA", PLACA);
                comand.Parameters.AddWithValue("@CATEGORIA", CATEGORIA);
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
        public void MODIFIC_TBL_VEHICULO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_VEHICULO_CLIENTE";
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_VEHICULO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@MARCA", MARCA);
                comand.Parameters.AddWithValue("@PLACA", PLACA);
                comand.Parameters.AddWithValue("@CATEGORIA", CATEGORIA);
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
        public DataTable SELECT_TBL_VEHICULO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_VEHICULO_CLIENTE";
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_VEHICULO);
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
        public void ELIMINAR_TBL_VEHICULO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_VEHICULO_CLIENTE";
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_VEHICULO);
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
