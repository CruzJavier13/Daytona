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
    class ClsFacturaRepuesto
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_FACT_REPUESTO;
        private int _ESTADO;
        private int _NUM_REPUESTO;
        private string _DESCRIPCION_REPUESTO;
        private double _UNIDAD;
        private int _NUM_EMPLEADO;
        private int _CLIENTE;
        private int _FORMA_PAGO;
        private int _MONEDA;
        private DateTime _FECHA;
        private double _CANTIDAD;
        private double _PRECIO_UNIDAD;
        private double _IVA;
        private double _TOTAL;

        public int NUM_FACT_REPUESTO
        {
            get
            {
                return _NUM_FACT_REPUESTO;
            }

            set
            {
                _NUM_FACT_REPUESTO = value;
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

        public string DESCRIPCION_REPUESTO
        {
            get
            {
                return _DESCRIPCION_REPUESTO;
            }

            set
            {
                _DESCRIPCION_REPUESTO = value;
            }
        }

        public double UNIDAD
        {
            get
            {
                return _UNIDAD;
            }

            set
            {
                _UNIDAD = value;
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

        public double CANTIDAD
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

        public double PRECIO_UNIDAD
        {
            get
            {
                return _PRECIO_UNIDAD;
            }

            set
            {
                _PRECIO_UNIDAD = value;
            }
        }

        public double IVA
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
        public void INSERT_TBL_FACTURA_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_FACTURA_REPUESTO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@DESCRIPCION_REPUESTO", DESCRIPCION_REPUESTO);
                comand.Parameters.AddWithValue("@UNIDAD", UNIDAD);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@CLIENTE", CLIENTE);
                comand.Parameters.AddWithValue("@FORMA_PAGO", FORMA_PAGO);
                comand.Parameters.AddWithValue("@MONEDA", MONEDA);
                comand.Parameters.AddWithValue("@FECHA", FECHA);
                comand.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
                comand.Parameters.AddWithValue("@PRECIO_UNIDAD", PRECIO_UNIDAD);
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
        public void MODIFIC_TBL_FACTURA_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_FACTURA_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_FACT_REPUESTO", NUM_FACT_REPUESTO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@DESCRIPCION_REPUESTO", DESCRIPCION_REPUESTO);
                comand.Parameters.AddWithValue("@UNIDAD", UNIDAD);
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@CLIENTE", CLIENTE);
                comand.Parameters.AddWithValue("@FORMA_PAGO", FORMA_PAGO);
                comand.Parameters.AddWithValue("@MONEDA", MONEDA);
                comand.Parameters.AddWithValue("@FECHA", FECHA);
                comand.Parameters.AddWithValue("@CANTIDAD", CANTIDAD);
                comand.Parameters.AddWithValue("@PRECIO_UNIDAD", PRECIO_UNIDAD);
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
        public DataTable SELECT_TBL_FACTURA_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_FACTURA_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_FACT_REPUESTO", NUM_FACT_REPUESTO);
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
        public void ELIMINAR_TBL_FACTURA_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_FACTURA_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_FACT_REPUESTO", NUM_FACT_REPUESTO);
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
