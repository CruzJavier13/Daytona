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
    class ClsRegistroMantenimiento
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _IDREGISTROM;
        private int _MANTENIMIENTO;
        private DateTime _FECHA_DATE;

        public int IDREGISTROM
        {
            get
            {
                return _IDREGISTROM;
            }

            set
            {
                _IDREGISTROM = value;
            }
        }

        public int MANTENIMIENTO
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

        public DateTime FECHA_DATE
        {
            get
            {
                return _FECHA_DATE;
            }

            set
            {
                _FECHA_DATE = value;
            }
        }
        public void INSERT_TBL_REGISTRO_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_REGISTRO_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@MANTENIMIENTO", MANTENIMIENTO);
                comand.Parameters.AddWithValue("@FECHA_DATE ", FECHA_DATE);
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
        public void MODIFIC_TBL_REGISTRO_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_TBL_REGISTRO_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@IDREGISTROM", IDREGISTROM);
                comand.Parameters.AddWithValue("@MANTENIMIENTO", MANTENIMIENTO);
                comand.Parameters.AddWithValue("@FECHA_DATE ", FECHA_DATE);
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
        public DataTable SELECT_TBL_REGISTRO_MANTENIMIENTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_REGISTRO_MANTENIMIENTO";
                comand.Parameters.AddWithValue("@IDREGISTROM", IDREGISTROM);
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
