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
    class ClsDetalleFacturaServicio
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_DETALLEF;
        private int _SERVICIO;
        private int _MECANICO;
        private int _FACTURA;

        public int NUM_DETALLEF
        {
            get
            {
                return _NUM_DETALLEF;
            }

            set
            {
                _NUM_DETALLEF = value;
            }
        }

        public int SERVICIO
        {
            get
            {
                return _SERVICIO;
            }

            set
            {
                _SERVICIO = value;
            }
        }

        public int MECANICO
        {
            get
            {
                return _MECANICO;
            }

            set
            {
                _MECANICO = value;
            }
        }

        public int FACTURA
        {
            get
            {
                return _FACTURA;
            }

            set
            {
                _FACTURA = value;
            }
        }
        public void INSERT_TBL_DETALLE_FACTURA_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_DETALLE_FACTURA_SERVICIO";
                comand.Parameters.AddWithValue("@SERVICIO", SERVICIO);
                comand.Parameters.AddWithValue("@MECANICO", MECANICO);
                comand.Parameters.AddWithValue("@FACTURA", FACTURA);
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
        public void MODIFIC_TBL_DETALLE_FACTURA_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_DETALLE_FACTURA_SERVICIO";
                comand.Parameters.AddWithValue("@NUM_DETALLEF", NUM_DETALLEF);
                comand.Parameters.AddWithValue("@SERVICIO", SERVICIO);
                comand.Parameters.AddWithValue("@MECANICO", MECANICO);
                comand.Parameters.AddWithValue("@FACTURA", FACTURA);
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
        public DataTable SELECT_TBL_DETALLE_FACTURA_SERVICIO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_DETALLE_FACTURA_SERVICIO";
                comand.Parameters.AddWithValue("@NUM_DETALLEF", NUM_DETALLEF);
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
