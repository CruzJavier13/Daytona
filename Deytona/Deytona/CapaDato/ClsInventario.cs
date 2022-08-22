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
    class ClsInventario
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _ID_INVENTARIO;
        private int _ESTADO;
        private int _NUM_REPUESTO;
        private float _CANTIDAD;
        private float _CANT_MIN;
        private float _EXISTENCIA;
        private float _DISPONIBILIDAD;
        private DateTime _DAT_FECHA_INVENTARIO;

        public int ID_INVENTARIO
        {
            get
            {
                return _ID_INVENTARIO;
            }

            set
            {
                _ID_INVENTARIO = value;
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

        public float CANT_MIN
        {
            get
            {
                return _CANT_MIN;
            }

            set
            {
                _CANT_MIN = value;
            }
        }

        

        public DateTime DAT_FECHA_INVENTARIO
        {
            get
            {
                return _DAT_FECHA_INVENTARIO;
            }

            set
            {
                _DAT_FECHA_INVENTARIO = value;
            }
        }
        public void INSERT_TBL_INVENTARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_INVENTARIO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@CANTIDAD ", CANTIDAD);
                comand.Parameters.AddWithValue("@CANT_MIN", CANT_MIN);
                comand.Parameters.AddWithValue("@DAT_FECHA_INVENTARIO", DAT_FECHA_INVENTARIO);
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
        public void MODIFIC_TBL_INVENTARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_INVENTARIO";
                comand.Parameters.AddWithValue("@ID_INVENTARIO", ID_INVENTARIO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@CANTIDAD ", CANTIDAD);
                comand.Parameters.AddWithValue("@CANT_MIN", CANT_MIN);
                comand.Parameters.AddWithValue("@DAT_FECHA_INVENTARIO", DAT_FECHA_INVENTARIO);
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
        public DataTable SELECT_TBL_INVENTARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_INVENTARIO";
                comand.Parameters.AddWithValue("@ID_INVENTARIO", ID_INVENTARIO);
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
        public void ELIMINAR_TBL_INVENTARIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_INVENTARIO";
                comand.Parameters.AddWithValue("@ID_INVENTARIO", ID_INVENTARIO);
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
