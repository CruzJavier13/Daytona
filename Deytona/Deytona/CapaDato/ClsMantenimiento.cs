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
    class ClsMantenimiento
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_MANTENIMIENTO;
        private int _VEHICULO;
        private int _TIPO_MANTENIMIENTO;
        private string _OBSERVACIONES;
        private int _REGISTRADO_POR;
        private DateTime _FECHA_MANTENIMIENTO;

        public int NUM_MANTENIMIENTO
        {
            get
            {
                return _NUM_MANTENIMIENTO;
            }

            set
            {
                _NUM_MANTENIMIENTO = value;
            }
        }

        public int VEHICULO
        {
            get
            {
                return _VEHICULO;
            }

            set
            {
                _VEHICULO = value;
            }
        }

        public int TIPO_MANTENIMIENTO
        {
            get
            {
                return _TIPO_MANTENIMIENTO;
            }

            set
            {
                _TIPO_MANTENIMIENTO = value;
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

        public int REGISTRADO_POR
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

        public DateTime FECHA_MANTENIMIENTO
        {
            get
            {
                return _FECHA_MANTENIMIENTO;
            }

            set
            {
                _FECHA_MANTENIMIENTO = value;
            }
        }
        public void INSERT_TBL_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@VEHICULO ", VEHICULO);
                comand.Parameters.AddWithValue("@TIPO_MANTENIMIENTO", TIPO_MANTENIMIENTO);
                comand.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES);
                comand.Parameters.AddWithValue("@REGISTRADO_POR", REGISTRADO_POR);
                comand.Parameters.AddWithValue("@FECHA_MANTENIMIENTO", FECHA_MANTENIMIENTO);
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
        public void MODIFIC_TBL_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@NUM_MANTENIMIENTO  ", NUM_MANTENIMIENTO);
                comand.Parameters.AddWithValue("@VEHICULO ", VEHICULO);
                comand.Parameters.AddWithValue("@TIPO_MANTENIMIENTO", TIPO_MANTENIMIENTO);
                comand.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES);
                comand.Parameters.AddWithValue("@REGISTRADO_POR", REGISTRADO_POR);
                comand.Parameters.AddWithValue("@FECHA_MANTENIMIENTO", FECHA_MANTENIMIENTO);
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
        public DataTable SELECT_TBL_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@NUM_MANTENIMIENTO", NUM_MANTENIMIENTO);
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
