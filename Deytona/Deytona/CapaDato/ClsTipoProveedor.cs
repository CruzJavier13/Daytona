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
    class ClsTipoProveedor
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _IDTIPOPROVEEDOR;
        private int _ESTADO;
        private string _TIPO;
        private string _DESCRIPCION;

        public int IDTIPOPROVEEDOR
        {
            get
            {
                return _IDTIPOPROVEEDOR;
            }

            set
            {
                _IDTIPOPROVEEDOR = value;
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

        public string TIPO
        {
            get
            {
                return _TIPO;
            }

            set
            {
                _TIPO = value;
            }
        }

        public string DESCRIPCION
        {
            get
            {
                return _DESCRIPCION;
            }

            set
            {
                _DESCRIPCION = value;
            }
        }
        public void INSERT_TBL_TIPO_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_TIPO_PROVEEDOR";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
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
        public void MODIFIC_TBL_TIPO_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_TIPO_PROVEEDOR";
                comand.Parameters.AddWithValue("@IDTIPOPROVEEDOR", IDTIPOPROVEEDOR);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
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
        public DataTable SELECT_TIPO_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INICIAR_SESION";
                comand.Parameters.AddWithValue("@IDTIPOPROVEEDOR", IDTIPOPROVEEDOR);
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
        public void ELIMINAR_TBL_TIPO_PROVEEDOR()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_TIPO_PROVEEDOR";
                comand.Parameters.AddWithValue("@IDTIPOPROVEEDOR", IDTIPOPROVEEDOR);
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
