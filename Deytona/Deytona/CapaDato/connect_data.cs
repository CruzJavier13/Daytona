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
    public class connect_data
    {
       // private static string connectionString = string.Format("Data Source=.;Initial Catalog=TALLER_DEYTONA;Integrated Security=True");
       //  SqlConnection connect = new SqlConnection(connectionString);

        private static string cadena = string.Format("Data Source= 192.168.0.11;Initial Catalog=TALLER_DEYTONA;Integrated Security=True");
        private SqlConnection conect = new SqlConnection(cadena);
        public SqlConnection Open()
        {
            if (conect.State == ConnectionState.Closed)
                conect.Open();

            return conect;
        }
        public SqlConnection Close()
        {
            if (conect.State == ConnectionState.Open)
                conect.Close();

            return conect;
        }

    }
}
