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
    class ClsProveedor
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_PROVEEDOR;
        private int _ESTADO ;
        private string _NUM_IDENTIFICACION;
        private int _TIPO_PROVEEDOR;
        private string _NOMBRE;
        private string _APELLIDO_RAZON_SOCIAL;
        private DateTime _FECHA_NAC_CONSTITUCION;
        private string _DIRECCION;
        private int _TELEFONO;
        private string _CORREO;
        private string _PAGWEB;
        private string _REGISTRADO_POR;
        private string _AUTORIZADO_POR;
        private DateTime _FECHAINGRESOSISTEM;

        public int NUM_PROVEEDOR
        {
            get
            {
                return _NUM_PROVEEDOR;
            }

            set
            {
                _NUM_PROVEEDOR = value;
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

        public string NUM_IDENTIFICACION
        {
            get
            {
                return _NUM_IDENTIFICACION;
            }

            set
            {
                _NUM_IDENTIFICACION = value;
            }
        }

        public int TIPO_PROVEEDOR
        {
            get
            {
                return _TIPO_PROVEEDOR;
            }

            set
            {
                _TIPO_PROVEEDOR = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return _NOMBRE;
            }

            set
            {
                _NOMBRE = value;
            }
        }

        public string APELLIDO_RAZON_SOCIAL
        {
            get
            {
                return _APELLIDO_RAZON_SOCIAL;
            }

            set
            {
                _APELLIDO_RAZON_SOCIAL = value;
            }
        }

        public DateTime FECHA_NAC_CONSTITUCION
        {
            get
            {
                return _FECHA_NAC_CONSTITUCION;
            }

            set
            {
                _FECHA_NAC_CONSTITUCION = value;
            }
        }

        public string DIRECCION
        {
            get
            {
                return _DIRECCION;
            }

            set
            {
                _DIRECCION = value;
            }
        }

        public int TELEFONO
        {
            get
            {
                return _TELEFONO;
            }

            set
            {
                _TELEFONO = value;
            }
        }

        public string CORREO
        {
            get
            {
                return _CORREO;
            }

            set
            {
                _CORREO = value;
            }
        }

        public string PAGWEB
        {
            get
            {
                return _PAGWEB;
            }

            set
            {
                _PAGWEB = value;
            }
        }

        public string REGISTRADO_POR
        {
            get
            {
                return _REGISTRADO_POR;
            }

            set
            {
                _REGISTRADO_POR = value;
            }
        }

        public string AUTORIZADO_POR
        {
            get
            {
                return _AUTORIZADO_POR;
            }

            set
            {
                _AUTORIZADO_POR = value;
            }
        }

        public DateTime FECHAINGRESOSISTEM
        {
            get
            {
                return _FECHAINGRESOSISTEM;
            }

            set
            {
                _FECHAINGRESOSISTEM = value;
            }
        }
        public void INSERT_CAT_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_PROVEEDOR";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_IDENTIFICACION", NUM_IDENTIFICACION);
                comand.Parameters.AddWithValue("@TIPO_PROVEEDOR", TIPO_PROVEEDOR);
                comand.Parameters.AddWithValue("@NOMBRE ", NOMBRE);
                comand.Parameters.AddWithValue("@APELLIDO_RAZON_SOCIAL", APELLIDO_RAZON_SOCIAL);
                comand.Parameters.AddWithValue("@FECHA_NAC_CONSTITUCION", FECHA_NAC_CONSTITUCION);
                comand.Parameters.AddWithValue("@DIRECCION", DIRECCION);
                comand.Parameters.AddWithValue("@TELEFONO", TELEFONO);
                comand.Parameters.AddWithValue("@CORREO ", CORREO);
                comand.Parameters.AddWithValue("@PAGWEB", PAGWEB);
                comand.Parameters.AddWithValue("@REGISTRADO_POR ", REGISTRADO_POR);
                comand.Parameters.AddWithValue("@AUTORIZADO_POR", AUTORIZADO_POR);
                comand.Parameters.AddWithValue("@FECHAINGRESOSISTEM", FECHAINGRESOSISTEM);
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
        public void MODIFIC_CAT_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_CAT_PROVEEDOR";
                comand.Parameters.AddWithValue("@NUM_PROVEEDOR", NUM_PROVEEDOR);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_IDENTIFICACION", NUM_IDENTIFICACION);
                comand.Parameters.AddWithValue("@TIPO_PROVEEDOR", TIPO_PROVEEDOR);
                comand.Parameters.AddWithValue("@NOMBRE ", NOMBRE);
                comand.Parameters.AddWithValue("@APELLIDO_RAZON_SOCIAL", APELLIDO_RAZON_SOCIAL);
                comand.Parameters.AddWithValue("@FECHA_NAC_CONSTITUCION", FECHA_NAC_CONSTITUCION);
                comand.Parameters.AddWithValue("@DIRECCION", DIRECCION);
                comand.Parameters.AddWithValue("@TELEFONO", TELEFONO);
                comand.Parameters.AddWithValue("@CORREO ", CORREO);
                comand.Parameters.AddWithValue("@PAGWEB", PAGWEB);
                comand.Parameters.AddWithValue("@REGISTRADO_POR ", REGISTRADO_POR);
                comand.Parameters.AddWithValue("@AUTORIZADO_POR", AUTORIZADO_POR);
                comand.Parameters.AddWithValue("@FECHAINGRESOSISTEM", FECHAINGRESOSISTEM);
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
        public DataTable SELECT_CAT_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CAT_PROVEEDOR";
                comand.Parameters.AddWithValue("@NUM_PROVEEDOR", NUM_PROVEEDOR);
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
        public void ELIMINAR_CAT_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CAT_PROVEEDOR";
                comand.Parameters.AddWithValue("@NUM_PROVEEDOR", NUM_PROVEEDOR);
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
