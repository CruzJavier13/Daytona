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
    class ClsEquipoMecanico
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_EQUIPO;
        private string _MOTOR;
        private string _CILINDROS;
        private string _TRANSMICION;
        private string _FRENOS;

        public int NUM_EQUIPO
        {
            get
            {
                return _NUM_EQUIPO;
            }

            set
            {
                _NUM_EQUIPO = value;
            }
        }

        public string MOTOR
        {
            get
            {
                return _MOTOR;
            }

            set
            {
                _MOTOR = value;
            }
        }

        public string CILINDROS
        {
            get
            {
                return _CILINDROS;
            }

            set
            {
                _CILINDROS = value;
            }
        }

        public string TRANSMICION
        {
            get
            {
                return _TRANSMICION;
            }

            set
            {
                _TRANSMICION = value;
            }
        }

        public string FRENOS
        {
            get
            {
                return _FRENOS;
            }

            set
            {
                _FRENOS = value;
            }
        }
        public void INSERT_EQUIPOMECANICO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_EQUIPOMECANICO";
                comand.Parameters.AddWithValue("@MOTOR", MOTOR);
                comand.Parameters.AddWithValue("@CILINDROS", CILINDROS);
                comand.Parameters.AddWithValue("@TRANSMICION", TRANSMICION);
                comand.Parameters.AddWithValue("@FRENOS", FRENOS);
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
        public void MODIFC_EQUIPOMECANICO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFC_EQUIPOMECANICO";
                comand.Parameters.AddWithValue("@NUM_EQUIPO", NUM_EQUIPO);
                comand.Parameters.AddWithValue("@MOTOR", MOTOR);
                comand.Parameters.AddWithValue("@CILINDROS", CILINDROS);
                comand.Parameters.AddWithValue("@TRANSMICION", TRANSMICION);
                comand.Parameters.AddWithValue("@FRENOS", FRENOS);
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
        public DataTable SELECT_EQUIPOMECANICO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_EQUIPOMECANICO";
                comand.Parameters.AddWithValue("@NUM_EQUIPO", NUM_EQUIPO);
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
