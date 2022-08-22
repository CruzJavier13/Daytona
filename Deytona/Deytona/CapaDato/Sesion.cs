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
   public class Sesion
    {

        SqlDataReader DataRead;
        DataTable table = new DataTable();
        SqlCommand comand = new SqlCommand();
        connect_data data = new connect_data();

        private string _USUARIO;
        private string _CONTRASENA;

        public string USUARIO
        {
            get
            {
                return _USUARIO;
            }

            set
            {
                _USUARIO = value;
            }
        }

        public string CONTRASENA
        {
            get
            {
                return _CONTRASENA;
            }

            set
            {
                _CONTRASENA = value;
            }
        }

        public DataTable IniciarSesion(string user,string pass)
        {
            try {
               
                comand.Connection = data.Open();
                comand.CommandText = "SP_INICIAR_SESION";
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@USUARIO", USUARIO);
                comand.Parameters.AddWithValue("@CONTRASENA", CONTRASENA);
                
                DataRead = comand.ExecuteReader();
                table.Load(DataRead);
                comand.Connection = data.Close();
                comand.Parameters.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error");
            }

            return table;
        }
    }
}
