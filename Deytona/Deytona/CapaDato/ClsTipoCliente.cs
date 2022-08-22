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
    public class ClsTipoCliente
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _IDTIPO;
        private int _ESTADO;
        private string _TIPO;
        private float _DESCUENTO;

        public int IDTIPO
        {
            get
            {
                return _IDTIPO;
            }

            set
            {
                _IDTIPO = value;
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

        public string TIPO
        {
            get
            {
                return _TIPO;
            }

            set
            {
                _TIPO = value;
            }
        }

        public float DESCUENTO
        {
            get
            {
                return _DESCUENTO;
            }

            set
            {
                _DESCUENTO = value;
            }
        }
        public void INSERT_TBL_TIPO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_TBL_TIPO_CLIENTE";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@DESCUENTO", DESCUENTO);
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
        public void MODIFC_TBL_TIPO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFC_TBL_TIPO_CLIENTE";
                comand.Parameters.AddWithValue("@IDTIPO", IDTIPO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@TIPO", TIPO);
                comand.Parameters.AddWithValue("@DESCUENTO", DESCUENTO);
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
        public DataTable SELECT_TBL_TIPO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_TBL_TIPO_CLIENTE";
                comand.Parameters.AddWithValue("@IDTIPO", IDTIPO);
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
        public void ELIMINAR_TBL_TIPO_CLIENTE()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_TBL_TIPO_CLIENTE";
                comand.Parameters.AddWithValue("@IDTIPO", IDTIPO);
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
