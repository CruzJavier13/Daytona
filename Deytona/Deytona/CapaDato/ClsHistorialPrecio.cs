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
    class ClsHistorialPrecio
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_HISTORIAL;
        private string _CODIGO;
        private float _PRECIO;
        private DateTime _FECHA;
        private string _DESCRIPCION;
        private string _NOMBRE_PRODUCTO;

        public int NUM_HISTORIAL
        {
            get
            {
                return _NUM_HISTORIAL;
            }

            set
            {
                _NUM_HISTORIAL = value;
            }
        }

        public string CODIGO
        {
            get
            {
                return _CODIGO;
            }

            set
            {
                _CODIGO = value;
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

        public string NOMBRE_PRODUCTO
        {
            get
            {
                return _NOMBRE_PRODUCTO;
            }

            set
            {
                _NOMBRE_PRODUCTO = value;
            }
        }

        //public void INSERT_TBL_HISTORIAL_PRECIO()
        //{
        //    try
        //    {

        //        comand.Connection = data.Open();
        //        comand.CommandText = "SP_INSERT_TBL_HISTORIAL_PRECIO";
        //        comand.Parameters.AddWithValue("@CODIGO ", CODIGO);
        //        comand.Parameters.AddWithValue("@PRECIO", PRECIO);
        //        comand.Parameters.AddWithValue("@FECHA", FECHA);
        //        comand.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
        //        comand.Parameters.AddWithValue("@NOMBRE_PRODUCTO", NOMBRE_PRODUCTO);
        //        comand.CommandType = CommandType.StoredProcedure;

        //        comand.ExecuteNonQuery();
        //        comand.Connection = data.Close();
        //        comand.Parameters.Clear();

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Error");
        //    }
        //}
        //public void MODIFIC_TBL_HISTORIAL_PRECIO()
        //{
        //    try
        //    {

        //        comand.Connection = data.Open();
        //        comand.CommandText = "SP_MODIFIC_TBL_HISTORIAL_PRECIO";
        //        comand.Parameters.AddWithValue("@NUM_HISTORIAL ", NUM_HISTORIAL);
        //        comand.Parameters.AddWithValue("@CODIGO ", CODIGO);
        //        comand.Parameters.AddWithValue("@PRECIO", PRECIO);
        //        comand.Parameters.AddWithValue("@FECHA", FECHA);
        //        comand.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
        //        comand.Parameters.AddWithValue("@NOMBRE_PRODUCTO", NOMBRE_PRODUCTO);
        //        comand.CommandType = CommandType.StoredProcedure;

        //        comand.ExecuteNonQuery();
        //        comand.Connection = data.Close();
        //        comand.Parameters.Clear();

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Error");
        //    }
        //}
        //public DataTable SELECT_TBL_HISTORIAL_PRECIO()
        //{
        //    try
        //    {

        //        comand.Connection = data.Open();
        //        comand.CommandText = "SP_SELECT_TBL_HISTORIAL_PRECIO";
        //        comand.Parameters.AddWithValue("@NUM_HISTORIAL", NUM_HISTORIAL);
        //        comand.CommandType = CommandType.StoredProcedure;

        //        DataRead = comand.ExecuteReader();
        //        table.Load(DataRead);
        //        comand.Connection = data.Close();
        //        comand.Parameters.Clear();

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Error");
        //    }

        //    return table;
        //}
        public DataTable SELECT_FECHA_TBL_HISTORIAL_PRECIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_HISTORIAL_PRECIO";
                comand.Parameters.AddWithValue("@FECHA", FECHA);
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
