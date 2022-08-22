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
    public class ClsEmpleado
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_EMPLEADO;
        private int _ESTADO;
        private string _NO_CEDULA;
        private string _NO_INSS;
        private string _NOMBRE;
        private string _APELLIDO;
        private DateTime _DAT_FECHA_NAC;
        private int _CARGO;
        private char _GENERO;
        private char _ESTADO_CIVIL;
        private string _DIRECCION;
        private int _NUM_TELEFONO;
        private string _CORREO;
        private string _WEB;

        public int NUM_EMPLEADO
        {
            get
            {
                return _NUM_EMPLEADO;
            }

            set
            {
                _NUM_EMPLEADO = value;
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

        public string NO_CEDULA
        {
            get
            {
                return _NO_CEDULA;
            }

            set
            {
                _NO_CEDULA = value;
            }
        }

        public string NO_INSS
        {
            get
            {
                return _NO_INSS;
            }

            set
            {
                _NO_INSS = value;
            }
        }

        public string NOMBRE
        {
            get
            {
                return _NOMBRE;
            }

            set
            {
                _NOMBRE = value;
            }
        }

        public string APELLIDO
        {
            get
            {
                return _APELLIDO;
            }

            set
            {
                _APELLIDO = value;
            }
        }

        public DateTime DAT_FECHA_NAC
        {
            get
            {
                return _DAT_FECHA_NAC;
            }

            set
            {
                _DAT_FECHA_NAC = value;
            }
        }

        public int CARGO
        {
            get
            {
                return _CARGO;
            }

            set
            {
                _CARGO = value;
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

        public string DIRECCION
        {
            get
            {
                return _DIRECCION;
            }

            set
            {
                _DIRECCION = value;
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
        public void INSERT_CAT_EMPLEADO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_EMPLEADO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NO_CEDULA", NO_CEDULA);
                comand.Parameters.AddWithValue("@NO_INSS", NO_INSS);
                comand.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                comand.Parameters.AddWithValue("@APELLIDO", APELLIDO);
                comand.Parameters.AddWithValue("@DAT_FECHA_NAC", DAT_FECHA_NAC);
                comand.Parameters.AddWithValue("@CARGO", CARGO);
                comand.Parameters.AddWithValue("@GENERO", GENERO);
                comand.Parameters.AddWithValue("@ESTADO_CIVIL", ESTADO_CIVIL);
                comand.Parameters.AddWithValue("@DIRECCION ", DIRECCION);
                comand.Parameters.AddWithValue("@NUM_TELEFONO", NUM_TELEFONO);
                comand.Parameters.AddWithValue("@CORREO", CORREO);
                comand.Parameters.AddWithValue("@WEB ", WEB);
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
        public void MODIFIC_CAT_EMPLEADO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_CAT_EMPLEADO";
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", NUM_EMPLEADO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NO_CEDULA", NO_CEDULA);
                comand.Parameters.AddWithValue("@NO_INSS", NO_INSS);
                comand.Parameters.AddWithValue("@NOMBRE", NOMBRE);
                comand.Parameters.AddWithValue("@APELLIDO", APELLIDO);
                comand.Parameters.AddWithValue("@DAT_FECHA_NAC", DAT_FECHA_NAC);
                comand.Parameters.AddWithValue("@CARGO", CARGO);
                comand.Parameters.AddWithValue("@GENERO", GENERO);
                comand.Parameters.AddWithValue("@ESTADO_CIVIL", ESTADO_CIVIL);
                comand.Parameters.AddWithValue("@DIRECCION ", DIRECCION);
                comand.Parameters.AddWithValue("@NUM_TELEFONO", NUM_TELEFONO);
                comand.Parameters.AddWithValue("@CORREO", CORREO);
                comand.Parameters.AddWithValue("@WEB ", WEB);
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
        public DataTable SELECT_CAT_EMPLEADO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CAT_EMPLEADO";
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", _NUM_EMPLEADO);
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
        public void ELIMINAR_CAT_EMPLEADO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CAT_EMPLEADO";
                comand.Parameters.AddWithValue("@NUM_EMPLEADO", NUM_EMPLEADO);
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
