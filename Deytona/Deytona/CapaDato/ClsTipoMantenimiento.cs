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
    class ClsTipoMantenimiento
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _ID_MANTENIMIENTO;
        private string _MANTENIMIENTO;
        private string _DESCRIPCION;

        public int ID_MANTENIMIENTO
        {
            get
            {
                return _ID_MANTENIMIENTO;
            }

            set
            {
                _ID_MANTENIMIENTO = value;
            }
        }

        public string MANTENIMIENTO
        {
            get
            {
                return _MANTENIMIENTO;
            }

            set
            {
                _MANTENIMIENTO = value;
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
        public void INSERT_TIPO_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TIPO_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@MANTENIMIENTO", MANTENIMIENTO);
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
             public void MODIFIC_TIPO_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TIPO_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@ID_MANTENIMIENTO", ID_MANTENIMIENTO);
                comand.Parameters.AddWithValue("@MANTENIMIENTO", MANTENIMIENTO);
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
        public DataTable SELECT_TIPO_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TIPO_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@ID_MANTENIMIENTO", ID_MANTENIMIENTO);
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
