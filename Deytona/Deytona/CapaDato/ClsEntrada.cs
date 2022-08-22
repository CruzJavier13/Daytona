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
    class ClsEntrada
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_ENTRADA;
        private int _NUM_DISTRIBUIDOR ;
        private int _NUM_EMPLEADO;
        private DateTime _DAT_FECHA;
        private string _OBSERVACIONES;
        private float _CANTIDAD;
        private float _SUBTOTAL;
        private float _DESCUENTO;
        private float _IMPUESTO;
        private float _TOTAL;

        public int NUM_ENTRADA
        {
            get
            {
                return _NUM_ENTRADA;
            }

            set
            {
                _NUM_ENTRADA = value;
            }
        }

        public int NUM_DISTRIBUIDOR
        {
            get
            {
                return _NUM_DISTRIBUIDOR;
            }

            set
            {
                _NUM_DISTRIBUIDOR = value;
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

        public float SUBTOTAL
        {
            get
            {
                return _SUBTOTAL;
            }

            set
            {
                _SUBTOTAL = value;
            }
        }

        public float DESCUENTO
        {
            get
            {
                return _DESCUENTO;
            }

            set
            {
                _DESCUENTO = value;
            }
        }

        public float IMPUESTO
        {
            get
            {
                return _IMPUESTO;
            }

            set
            {
                _IMPUESTO = value;
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

        public void INSERT_TBL_ENTRADA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_ENTRADA";
                comand.Parameters.AddWithValue("@NUM_DISTRIBUIDOR", NUM_DISTRIBUIDOR);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", NUM_EMPLEADO);
                comand.Parameters.AddWithValue("@DAT_FECHA", DAT_FECHA);
                comand.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES);
                comand.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
                comand.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
                comand.Parameters.AddWithValue("@DESCUENTO", DESCUENTO);
                comand.Parameters.AddWithValue("@IMPUESTO", IMPUESTO);
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
        public void MODIFIC_TBL_ENTRADA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_ENTRADA";
                comand.Parameters.AddWithValue("@NUM_ENTRADA ", NUM_ENTRADA);
                comand.Parameters.AddWithValue("@NUM_DISTRIBUIDOR", NUM_DISTRIBUIDOR);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", NUM_EMPLEADO);
                comand.Parameters.AddWithValue("@DAT_FECHA", DAT_FECHA);
                comand.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES);
                comand.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
                comand.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
                comand.Parameters.AddWithValue("@DESCUENTO", DESCUENTO);
                comand.Parameters.AddWithValue("@IMPUESTO", IMPUESTO);
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
        public DataTable SELECT_TBL_ENTRADA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_ENTRADA";
                comand.Parameters.AddWithValue("@NUM_ENTRADA", NUM_ENTRADA);
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
