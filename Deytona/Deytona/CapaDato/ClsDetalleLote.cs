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
    class ClsDetalleLote
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUMDETALLE;
        private int _VEHICULO;
        private int _LOTE;

        public int NUMDETALLE
        {
            get
            {
                return _NUMDETALLE;
            }

            set
            {
                _NUMDETALLE = value;
            }
        }

        public int VEHICULO
        {
            get
            {
                return _VEHICULO;
            }

            set
            {
                _VEHICULO = value;
            }
        }

        public int LOTE
        {
            get
            {
                return _LOTE;
            }

            set
            {
                _LOTE = value;
            }
        }
        public void INSERT_TBL_DETALLE_LOTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_DETALLE_LOTE";
                comand.Parameters.AddWithValue("@VEHICULO", VEHICULO);
                comand.Parameters.AddWithValue("@LOTE", LOTE);
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
        public void MODIFIC_TBL_DETALLE_LOTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_DETALLE_LOTE";
                comand.Parameters.AddWithValue("@NUMDETALLE", NUMDETALLE);
                comand.Parameters.AddWithValue("@VEHICULO", VEHICULO);
                comand.Parameters.AddWithValue("@LOTE", LOTE);
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
        public DataTable SELECT_TBL_DETALLE_LOTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_DETALLE_LOTE";
                comand.Parameters.AddWithValue("@NUMDETALLE", NUMDETALLE);
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
    }
}
