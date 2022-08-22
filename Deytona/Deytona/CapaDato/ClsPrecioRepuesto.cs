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
    class ClsPrecioRepuesto
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_PRECIO_REPUESTO;
        private int _NUM_REPUESTO;
        private int _ESTADO;
        private float _PRECIO_COMPRA;
        private float _IVA;
        private float _TOTAL;

        public int NUM_PRECIO_REPUESTO
        {
            get
            {
                return _NUM_PRECIO_REPUESTO;
            }

            set
            {
                _NUM_PRECIO_REPUESTO = value;
            }
        }

        public int NUM_REPUESTO
        {
            get
            {
                return _NUM_REPUESTO;
            }

            set
            {
                _NUM_REPUESTO = value;
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

        public float PRECIO_COMPRA
        {
            get
            {
                return _PRECIO_COMPRA;
            }

            set
            {
                _PRECIO_COMPRA = value;
            }
        }

        public float IVA
        {
            get
            {
                return _IVA;
            }

            set
            {
                _IVA = value;
            }
        }

        public float TOTAL
        {
            get
            {
                return _TOTAL;
            }

            set
            {
                _TOTAL = value;
            }
        }
        public void INSERT_TBL_PRECIO_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_PRECIO_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@PRECIO_COMPRA", PRECIO_COMPRA);
                comand.Parameters.AddWithValue("@IVA", IVA);
                comand.Parameters.AddWithValue("@TOTAL", TOTAL);
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
        public void MODIFIC_TBL_PRECIO_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_PRECIO_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_PRECIO_REPUESTO", _NUM_PRECIO_REPUESTO);
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@PRECIO_COMPRA", PRECIO_COMPRA);
                comand.Parameters.AddWithValue("@IVA", IVA);
                comand.Parameters.AddWithValue("@TOTAL", TOTAL);
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
        public DataTable SELECT_TBL_PRECIO_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_PRECIO_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_PRECIO_REPUESTO", _NUM_PRECIO_REPUESTO);
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
        public void ELIMINAR_TBL_PRECIO_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_PRECIO_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_PRECIO_REPUESTO", _NUM_PRECIO_REPUESTO);
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
