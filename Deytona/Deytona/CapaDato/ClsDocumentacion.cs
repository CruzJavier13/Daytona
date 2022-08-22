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
    class ClsDocumentacion
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_DOCUMENTACION;
        private string _CARTA_COMPRA_VENTA;
        private string _CIRCULACION;
        private string _MATRICULA;

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

        public string CARTA_COMPRA_VENTA
        {
            get
            {
                return _CARTA_COMPRA_VENTA;
            }

            set
            {
                _CARTA_COMPRA_VENTA = value;
            }
        }

        public string CIRCULACION
        {
            get
            {
                return _CIRCULACION;
            }

            set
            {
                _CIRCULACION = value;
            }
        }

        public string MATRICULA
        {
            get
            {
                return _MATRICULA;
            }

            set
            {
                _MATRICULA = value;
            }
        }
        public void INSERT_DOCUMENTACION()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_DOCUMENTACION";
                comand.Parameters.AddWithValue("@CARTA_COMPRA_VENTA", CARTA_COMPRA_VENTA);
                comand.Parameters.AddWithValue("@CIRCULACION", CIRCULACION);
                comand.Parameters.AddWithValue("@MATRICULA", MATRICULA);
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
        public void Modificar_DOCUMENTACION()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_DOCUMENTACION";
                comand.Parameters.AddWithValue("@NUM_DOCUMENTACION", NUM_DOCUMENTACION);
                comand.Parameters.AddWithValue("@CARTA_COMPRA_VENTA", CARTA_COMPRA_VENTA);
                comand.Parameters.AddWithValue("@CIRCULACION", CIRCULACION);
                comand.Parameters.AddWithValue("@MATRICULA", MATRICULA);
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
        public DataTable SELECT_DOCUMENTACION()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_DOCUMENTACION";
                comand.Parameters.AddWithValue("@NUM_DOCUMENTACION", NUM_DOCUMENTACION);
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
