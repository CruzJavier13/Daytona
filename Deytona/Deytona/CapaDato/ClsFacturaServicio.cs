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
    class ClsFacturaServicio
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_FACTURA_SERVICIO;
        private int _CLIENTE;
        private int _EMPLEADO;
        private DateTime _FECHA;
        private int _NUM_DETALLE_SERVICIO;
        private int _NUM_VEHICULO;
        private int _TIPO_SERVICIO;
        private int _MONEDA;
        private int _FORMA_PAGO;
        private float _PRECIO;
        private float _IMPUESTO;
        private double _TOTAL;

        public int NUM_FACTURA_SERVICIO
        {
            get
            {
                return _NUM_FACTURA_SERVICIO;
            }

            set
            {
                _NUM_FACTURA_SERVICIO = value;
            }
        }

        public int CLIENTE
        {
            get
            {
                return _CLIENTE;
            }

            set
            {
                _CLIENTE = value;
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

        public DateTime FECHA
        {
            get
            {
                return _FECHA;
            }

            set
            {
                _FECHA = value;
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

        public int TIPO_SERVICIO
        {
            get
            {
                return _TIPO_SERVICIO;
            }

            set
            {
                _TIPO_SERVICIO = value;
            }
        }

        public float PRECIO
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

        public void INSERT_TBL_FACTURA_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_FACTURA_SERVICIO";
                comand.Parameters.AddWithValue("@CLIENTE", CLIENTE);
                comand.Parameters.AddWithValue("@EMPLEADO", EMPLEADO);
                comand.Parameters.AddWithValue("@FECHA", FECHA);
                comand.Parameters.AddWithValue("@NUM_DETALLE_SERVICIO", NUM_DETALLE_SERVICIO);
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_VEHICULO);
                comand.Parameters.AddWithValue("@TIPO_SERVICIO", TIPO_SERVICIO);
                comand.Parameters.AddWithValue("@MONEDA", MONEDA);
                comand.Parameters.AddWithValue("@FORMA_PAGO", FORMA_PAGO);
                comand.Parameters.AddWithValue("@PRECIO", PRECIO);
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
        public void MODIFIC_TBL_FACTURA_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_FACTURA_SERVICIO";
                comand.Parameters.AddWithValue("@NUM_FACTURA_SERVICIO", NUM_FACTURA_SERVICIO);
                comand.Parameters.AddWithValue("@CLIENTE", CLIENTE);
                comand.Parameters.AddWithValue("@EMPLEADO", EMPLEADO);
                comand.Parameters.AddWithValue("@FECHA", FECHA);
                comand.Parameters.AddWithValue("@NUM_DETALLE_SERVICIO", NUM_DETALLE_SERVICIO);
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_VEHICULO);
                comand.Parameters.AddWithValue("@TIPO_SERVICIO", TIPO_SERVICIO);
                comand.Parameters.AddWithValue("@MONEDA", MONEDA);
                comand.Parameters.AddWithValue("@FORMA_PAGO", FORMA_PAGO);
                comand.Parameters.AddWithValue("@PRECIO", PRECIO);
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
        public DataTable SELECT_TBL_FACTURA_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_FACTURA_SERVICIO";
                comand.Parameters.AddWithValue("@NUM_FACTURA_SERVICIO", NUM_FACTURA_SERVICIO);
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
