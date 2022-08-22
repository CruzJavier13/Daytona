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
    class ClsLote
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _IDLOTE;
        private int _EMPLEADO;
        private int _DISTRIBUIDOR;
        private DateTime _FECHA_INGRESO;

        public int IDLOTE
        {
            get
            {
                return _IDLOTE;
            }

            set
            {
                _IDLOTE = value;
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

        public int DISTRIBUIDOR
        {
            get
            {
                return _DISTRIBUIDOR;
            }

            set
            {
                _DISTRIBUIDOR = value;
            }
        }

        public DateTime FECHA_INGRESO
        {
            get
            {
                return _FECHA_INGRESO;
            }

            set
            {
                _FECHA_INGRESO = value;
            }
        }
        public void INSERT_TBL_LOTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_LOTE";
                comand.Parameters.AddWithValue("@EMPLEADO", EMPLEADO);
                comand.Parameters.AddWithValue("@DISTRIBUIDOR", DISTRIBUIDOR);
                comand.Parameters.AddWithValue("@FECHA_INGRESO", FECHA_INGRESO);
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
        public void MODIFIC_TBL_LOTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_LOTE";
                comand.Parameters.AddWithValue("@IDLOTE ", IDLOTE);
                comand.Parameters.AddWithValue("@EMPLEADO", EMPLEADO);
                comand.Parameters.AddWithValue("@DISTRIBUIDOR", DISTRIBUIDOR);
                comand.Parameters.AddWithValue("@FECHA_INGRESO", FECHA_INGRESO);
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
        public DataTable SELECT_TBL_LOTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_LOTE";
                comand.Parameters.AddWithValue("@IDLOTE", IDLOTE);
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
