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
   public class ClsVehiculo
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_VEHICULO;
        private int _NUM_DOCUMENTACION;
        private int _NUM_EQUIPOMECANICO;
        private string _OBSERVACIONES;
        private float _PRECIO_COMPRA;
        private float _PRECIO_VENTA;
        private int _ESTADO;

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

        public int NUM_DOCUMENTACION
        {
            get
            {
                return _NUM_DOCUMENTACION;
            }

            set
            {
                _NUM_DOCUMENTACION = value;
            }
        }

        public int NUM_EQUIPOMECANICO
        {
            get
            {
                return _NUM_EQUIPOMECANICO;
            }

            set
            {
                _NUM_EQUIPOMECANICO = value;
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

        public float PRECIO_COMPRA
        {
            get
            {
                return _PRECIO_COMPRA;
            }

            set
            {
                _PRECIO_COMPRA = value;
            }
        }

        public float PRECIO_VENTA
        {
            get
            {
                return _PRECIO_VENTA;
            }

            set
            {
                _PRECIO_VENTA = value;
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
        public void INSERT_TBL_VEHICULO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_VEHICULO";
                comand.Parameters.AddWithValue("@NUM_DOCUMENTACION", NUM_DOCUMENTACION);
                comand.Parameters.AddWithValue("@NUM_EQUIPOMECANICO", NUM_EQUIPOMECANICO);
                comand.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES);
                comand.Parameters.AddWithValue("@PRECIO_COMPRA", PRECIO_COMPRA);
                comand.Parameters.AddWithValue("@PRECIO_VENTA", PRECIO_VENTA);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
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
        public void MODIFIC_TBL_VEHICULO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_VEHICULO";
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_DOCUMENTACION);
                comand.Parameters.AddWithValue("@NUM_DOCUMENTACION", NUM_DOCUMENTACION);
                comand.Parameters.AddWithValue("@NUM_EQUIPOMECANICO", NUM_EQUIPOMECANICO);
                comand.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES);
                comand.Parameters.AddWithValue("@PRECIO_COMPRA", PRECIO_COMPRA);
                comand.Parameters.AddWithValue("@PRECIO_VENTA", PRECIO_VENTA);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
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
        public DataTable SELECT_TBL_VEHICULO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_VEHICULO";
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_DOCUMENTACION);
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
        public void ELIMINAR_TBL_VEHICULO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_VEHICULO";
                comand.Parameters.AddWithValue("@NUM_VEHICULO", NUM_DOCUMENTACION);
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
