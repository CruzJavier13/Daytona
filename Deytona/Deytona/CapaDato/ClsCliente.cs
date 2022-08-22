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
    public class ClsCliente
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_CLIENTE;
        private int _ESTADO;
        private string _NOMBRE_CLIENTE;
        private string _APELLIDO_CLIENTE;
        private string _CEDULA_CLIENTE;
        private char _GENERO;
        private DateTime _FECHA_NAC;
        private char _ESTADO_CIVIL;
        private string _DOMICILIO;
        private int _NUM_TELEFONO;
        private string _WEB;
        private string _CORREO;
        private string _TIPO_CLIENTE;
        private string _VEHICULO;

        public int NUM_CLIENTE
        {
            get
            {
                return _NUM_CLIENTE;
            }

            set
            {
                _NUM_CLIENTE = value;
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

        public string NOMBRE_CLIENTE
        {
            get
            {
                return _NOMBRE_CLIENTE;
            }

            set
            {
                _NOMBRE_CLIENTE = value;
            }
        }

        public string APELLIDO_CLIENTE
        {
            get
            {
                return _APELLIDO_CLIENTE;
            }

            set
            {
                _APELLIDO_CLIENTE = value;
            }
        }

        public string CEDULA_CLIENTE
        {
            get
            {
                return _CEDULA_CLIENTE;
            }

            set
            {
                _CEDULA_CLIENTE = value;
            }
        }

        public char GENERO
        {
            get
            {
                return _GENERO;
            }

            set
            {
                _GENERO = value;
            }
        }

        public DateTime FECHA_NAC
        {
            get
            {
                return _FECHA_NAC;
            }

            set
            {
                _FECHA_NAC = value;
            }
        }

        public char ESTADO_CIVIL
        {
            get
            {
                return _ESTADO_CIVIL;
            }

            set
            {
                _ESTADO_CIVIL = value;
            }
        }

        public string DOMICILIO
        {
            get
            {
                return _DOMICILIO;
            }

            set
            {
                _DOMICILIO = value;
            }
        }

        public int NUM_TELEFONO
        {
            get
            {
                return _NUM_TELEFONO;
            }

            set
            {
                _NUM_TELEFONO = value;
            }
        }

        public string WEB
        {
            get
            {
                return _WEB;
            }

            set
            {
                _WEB = value;
            }
        }

        public string CORREO
        {
            get
            {
                return _CORREO;
            }

            set
            {
                _CORREO = value;
            }
        }

        public string TIPO_CLIENTE
        {
            get
            {
                return _TIPO_CLIENTE;
            }

            set
            {
                _TIPO_CLIENTE = value;
            }
        }

        public string VEHICULO
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
        public void INSERT_CAT_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_CLIENTE";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NOMBRE_CLIENTE", NOMBRE_CLIENTE);
                comand.Parameters.AddWithValue("@APELLIDO_CLIENTE", APELLIDO_CLIENTE);
                comand.Parameters.AddWithValue("@CEDULA_CLIENTE", CEDULA_CLIENTE);
                comand.Parameters.AddWithValue("@GENERO ", GENERO);
                comand.Parameters.AddWithValue("@FECHA_NAC ", FECHA_NAC);
                comand.Parameters.AddWithValue("@ESTADO_CIVIL", ESTADO_CIVIL);
                comand.Parameters.AddWithValue("@DOMICILIO", DOMICILIO);
                comand.Parameters.AddWithValue("@NUM_TELEFONO", NUM_TELEFONO);
                comand.Parameters.AddWithValue("@WEB", WEB);
                comand.Parameters.AddWithValue("@CORREO", CORREO);
                comand.Parameters.AddWithValue("@TIPO_CLIENTE", TIPO_CLIENTE);
                comand.Parameters.AddWithValue("@VEHICULO", VEHICULO);
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
        public void MODIFIC_CAT_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_CAT_CLIENTE";
                comand.Parameters.AddWithValue("@NUM_CLIENTE", NUM_CLIENTE);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NOMBRE_CLIENTE", NOMBRE_CLIENTE);
                comand.Parameters.AddWithValue("@APELLIDO_CLIENTE", APELLIDO_CLIENTE);
                comand.Parameters.AddWithValue("@CEDULA_CLIENTE", CEDULA_CLIENTE);
                comand.Parameters.AddWithValue("@GENERO ", GENERO);
                comand.Parameters.AddWithValue("@FECHA_NAC ", FECHA_NAC);
                comand.Parameters.AddWithValue("@ESTADO_CIVIL", ESTADO_CIVIL);
                comand.Parameters.AddWithValue("@DOMICILIO", DOMICILIO);
                comand.Parameters.AddWithValue("@NUM_TELEFONO", NUM_TELEFONO);
                comand.Parameters.AddWithValue("@WEB", WEB);
                comand.Parameters.AddWithValue("@CORREO", CORREO);
                comand.Parameters.AddWithValue("@TIPO_CLIENTE", TIPO_CLIENTE);
                comand.Parameters.AddWithValue("@VEHICULO", VEHICULO);
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
        public DataTable SELECT_CAT_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CAT_CLIENTE";
                comand.Parameters.AddWithValue("@NUM_CLIENTE", NUM_CLIENTE);
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
        public void ELIMINAR_CAT_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CAT_CLIENTE";
                comand.Parameters.AddWithValue("@NUM_CLIENTE", NUM_CLIENTE);
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
