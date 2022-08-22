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
    class ClsCategoria
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_CATEGORIA;
        private int _ESTADO;
        private string _NOMBRE_CATEGORIA;
        private string _DESCRIPCION_CATEG;

        public int NUM_CATEGORIA
        {
            get
            {
                return _NUM_CATEGORIA;
            }

            set
            {
                _NUM_CATEGORIA = value;
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

        public string NOMBRE_CATEGORIA
        {
            get
            {
                return _NOMBRE_CATEGORIA;
            }

            set
            {
                _NOMBRE_CATEGORIA = value;
            }
        }

        public string DESCRIPCION_CATEG
        {
            get
            {
                return _DESCRIPCION_CATEG;
            }

            set
            {
                _DESCRIPCION_CATEG = value;
            }
        }
        public void INSERT_CAT_CATEGORIA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_CATEGORIA";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NOMBRE_CATEGORIA", NOMBRE_CATEGORIA);
                comand.Parameters.AddWithValue("@DESCRIPCION_CATEG", DESCRIPCION_CATEG);
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
        public void MODIFIC_CAT_CATEGORIA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_CATEGORIA";
                comand.Parameters.AddWithValue("@NUM_CATEGORIA ", NUM_CATEGORIA);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NOMBRE_CATEGORIA", NOMBRE_CATEGORIA);
                comand.Parameters.AddWithValue("@DESCRIPCION_CATEG", DESCRIPCION_CATEG);
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
        public DataTable SELECT_CAT_CATEGORIA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CAT_CATEGORIA";
                comand.Parameters.AddWithValue("@NUM_CATEGORIA", NUM_CATEGORIA);
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
        public void ELIMINAR_CAT_CATEGORIA()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CAT_CATEGORIA";
                comand.Parameters.AddWithValue("@NUM_CATEGORIA ", NUM_CATEGORIA);
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
