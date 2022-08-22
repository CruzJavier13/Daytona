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
    class ClsFactura
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_FACTURA;
        private int _NUM_VEHICULO;
        private int _NUM_CLIENTE;
        private int _NUM_EMPLEADO;
        private int _ESTADO;
        private int _FORMA_PAGO;
        private int _MONEDA;
        private DateTime _FECHA_FACTURA;
        private float _CANTIDAD;
        private double _SUB_TOTAL;
        private float _IMPUESTO;
        private double _TOTAL;

        public int NUM_FACTURA
        {
            get
            {
                return _NUM_FACTURA;
            }

            set
            {
                _NUM_FACTURA = value;
            }
        }

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

        public int NUM_CLIENTE
        {
            get
            {
                return _NUM_CLIENTE;
            }

            set
            {
                _NUM_CLIENTE = value;
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

        public int FORMA_PAGO
        {
            get
            {
                return _FORMA_PAGO;
            }

            set
            {
                _FORMA_PAGO = value;
            }
        }

        public int MONEDA
        {
            get
            {
                return _MONEDA;
            }

            set
            {
                _MONEDA = value;
            }
        }

        public DateTime FECHA_FACTURA
        {
            get
            {
                return _FECHA_FACTURA;
            }

            set
            {
                _FECHA_FACTURA = value;
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

        public double SUB_TOTAL
        {
            get
            {
                return _SUB_TOTAL;
            }

            set
            {
                _SUB_TOTAL = value;
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

        public double TOTAL
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

        public void INSERT_TBL_FACTURA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_FACTURA";
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_VEHICULO);
                comand.Parameters.AddWithValue("@NUM_CLIENTE", NUM_CLIENTE);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", NUM_EMPLEADO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@FORMA_PAGO;", FORMA_PAGO);
                comand.Parameters.AddWithValue("@MONEDA", MONEDA);
                comand.Parameters.AddWithValue("@FECHA_FACTURA", FECHA_FACTURA);
                comand.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
                comand.Parameters.AddWithValue("@SUB_TOTAL", SUB_TOTAL);
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
        public void MODIFIC_TBL_FACTURA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_FACTURA";
                comand.Parameters.AddWithValue("@NUM_FACTURA",NUM_FACTURA);
                comand.Parameters.AddWithValue("@NUM_VEHICULO",NUM_VEHICULO);
                comand.Parameters.AddWithValue("@NUM_CLIENTE",NUM_CLIENTE);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO",NUM_EMPLEADO);
                comand.Parameters.AddWithValue("@ESTADO",ESTADO);
                comand.Parameters.AddWithValue("@FORMA_PAGO;", FORMA_PAGO);
                comand.Parameters.AddWithValue("@MONEDA",MONEDA);
                comand.Parameters.AddWithValue("@FECHA_FACTURA", FECHA_FACTURA);
                comand.Parameters.AddWithValue("@CANTIDAD",CANTIDAD);
                comand.Parameters.AddWithValue("@SUB_TOTAL",SUB_TOTAL);
                comand.Parameters.AddWithValue("@IMPUESTO",IMPUESTO);
                comand.Parameters.AddWithValue("@TOTAL",TOTAL);
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
        public DataTable SELECT_TBL_FACTURA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_FACTURA";
                comand.Parameters.AddWithValue("@NUM_FACTURA ", NUM_FACTURA);
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
