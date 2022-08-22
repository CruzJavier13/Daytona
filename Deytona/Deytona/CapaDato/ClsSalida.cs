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
    class ClsSalida
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_SALIDA;
        private int _NUM_REPUESTO;
        private int _NUM_EMPLEADO;
        private DateTime _DAT_FECHA;
        private string _TIPO_SALIDA;
        private string _OBSERVACIONES;
        private float _CANTIDAD;

        public int NUM_SALIDA
        {
            get
            {
                return _NUM_SALIDA;
            }

            set
            {
                _NUM_SALIDA = value;
            }
        }

        public int NUM_EMPLEADO
        {
            get
            {
                return _NUM_EMPLEADO;
            }

            set
            {
                _NUM_EMPLEADO = value;
            }
        }

        public DateTime DAT_FECHA
        {
            get
            {
                return _DAT_FECHA;
            }

            set
            {
                _DAT_FECHA = value;
            }
        }

        public string TIPO_SALIDA
        {
            get
            {
                return _TIPO_SALIDA;
            }

            set
            {
                _TIPO_SALIDA = value;
            }
        }

        public string OBSERVACIONES
        {
            get
            {
                return _OBSERVACIONES;
            }

            set
            {
                _OBSERVACIONES = value;
            }
        }

        public float CANTIDAD
        {
            get
            {
                return _CANTIDAD;
            }

            set
            {
                _CANTIDAD = value;
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

        public void INSERT_TBL_SALIDA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_SALIDA";
                comand.Parameters.AddWithValue("@NUM_REPUESTO ", _NUM_REPUESTO);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO ", _NUM_EMPLEADO);
                comand.Parameters.AddWithValue("@DAT_FECHA", _DAT_FECHA);
                comand.Parameters.AddWithValue("@TIPO_SALIDA", _TIPO_SALIDA);
                comand.Parameters.AddWithValue("@OBSERVACIONES", _OBSERVACIONES);
                comand.Parameters.AddWithValue("@CANTIDAD", _CANTIDAD);
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
        public void MODIFIC_TBL_SALIDA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_SALIDA";
                comand.Parameters.AddWithValue("@NUM_REPUESTO ", _NUM_REPUESTO);
                comand.Parameters.AddWithValue("@NUM_SALIDA ", NUM_SALIDA);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO ", NUM_EMPLEADO);
                comand.Parameters.AddWithValue("@DAT_FECHA", DAT_FECHA);
                comand.Parameters.AddWithValue("@TIPO_SALIDA", TIPO_SALIDA);
                comand.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES);
                comand.Parameters.AddWithValue("@CANTIDAD",_CANTIDAD);
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
        public DataTable SELECT_TBL_SALIDA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_SALIDA";
                comand.Parameters.AddWithValue("@NUM_SALIDA", NUM_SALIDA);
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
        public DataTable SELECT_FECHA_TBL_SALIDA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_SALIDA";
                comand.Parameters.AddWithValue("@NUM_SALIDA", NUM_SALIDA);
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
