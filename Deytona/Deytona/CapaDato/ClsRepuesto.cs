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
    class ClsRepuesto
    {
        connect_data data = new connect_data();
        SqlCommand comand = new SqlCommand();
        DataTable table = new DataTable();
        SqlDataReader DataRead;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();

        private int _NUM_REPUESTO;
        private int _ESTADO;
        private int _NUM_CATEGORIA;
        private string _NOMBRE_REPUESTO;
        private string _DESCRIPCION_REPUESTO;
        private string _UNIDAD_MEDIDA;
        private string _NUM_SERIE;
        private string _CODIGO_BARRA;
        private double _PRECIO_COMPRA;
        private string _REGISTRADO_POR;
        private DateTime _FECHA_REGISTRO;

        public int NUM_REPUESTO
        {
            get
            {
                return _NUM_REPUESTO;
            }

            set
            {
                _NUM_REPUESTO = value;
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

        public string NOMBRE_REPUESTO
        {
            get
            {
                return _NOMBRE_REPUESTO;
            }

            set
            {
                _NOMBRE_REPUESTO = value;
            }
        }

        public string DESCRIPCION_REPUESTO
        {
            get
            {
                return _DESCRIPCION_REPUESTO;
            }

            set
            {
                _DESCRIPCION_REPUESTO = value;
            }
        }

        public string UNIDAD_MEDIDA
        {
            get
            {
                return _UNIDAD_MEDIDA;
            }

            set
            {
                _UNIDAD_MEDIDA = value;
            }
        }

        public string NUM_SERIE
        {
            get
            {
                return _NUM_SERIE;
            }

            set
            {
                _NUM_SERIE = value;
            }
        }

        public string CODIGO_BARRA
        {
            get
            {
                return _CODIGO_BARRA;
            }

            set
            {
                _CODIGO_BARRA = value;
            }
        }

        public double PRECIO_COMPRA
        {
            get
            {
                return _PRECIO_COMPRA;
            }

            set
            {
                _PRECIO_COMPRA = value;
            }
        }

        public string REGISTRADO_POR
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

        public DateTime FECHA_REGISTRO
        {
            get
            {
                return _FECHA_REGISTRO;
            }

            set
            {
                _FECHA_REGISTRO = value;
            }
        }
        public void INSERT_CAT_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_INSERT_CAT_REPUESTO";
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_CATEGORIA", NUM_CATEGORIA);
                comand.Parameters.AddWithValue("@NOMBRE_REPUESTO", NOMBRE_REPUESTO);
                comand.Parameters.AddWithValue("@DESCRIPCION_REPUESTO", DESCRIPCION_REPUESTO);
                comand.Parameters.AddWithValue("@UNIDAD_MEDIDA", UNIDAD_MEDIDA);
                comand.Parameters.AddWithValue("@NUM_SERIE", NUM_SERIE);
                comand.Parameters.AddWithValue("@CODIGO_BARRA", CODIGO_BARRA);
                comand.Parameters.AddWithValue("@PRECIO_COMPRA", PRECIO_COMPRA);
                comand.Parameters.AddWithValue("@REGISTRADO_POR", REGISTRADO_POR);
                comand.Parameters.AddWithValue("@FECHA_REGISTRO ", FECHA_REGISTRO);
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
        public void MODIFIC_CAT_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_MODIFIC_CAT_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
                comand.Parameters.AddWithValue("@ESTADO", ESTADO);
                comand.Parameters.AddWithValue("@NUM_CATEGORIA", NUM_CATEGORIA);
                comand.Parameters.AddWithValue("@NOMBRE_REPUESTO", NOMBRE_REPUESTO);
                comand.Parameters.AddWithValue("@DESCRIPCION_REPUESTO", DESCRIPCION_REPUESTO);
                comand.Parameters.AddWithValue("@UNIDAD_MEDIDA", UNIDAD_MEDIDA);
                comand.Parameters.AddWithValue("@NUM_SERIE", NUM_SERIE);
                comand.Parameters.AddWithValue("@CODIGO_BARRA", CODIGO_BARRA);
                comand.Parameters.AddWithValue("@PRECIO_COMPRA", PRECIO_COMPRA);
                comand.Parameters.AddWithValue("@REGISTRADO_POR", REGISTRADO_POR);
                comand.Parameters.AddWithValue("@FECHA_REGISTRO ", FECHA_REGISTRO);
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
        public DataTable SELECT_CAT_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_SELECT_CAT_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
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

        public void ELIMINAR_CAT_REPUESTO()
        {
            try
            {

                comand.Connection = data.Open();
                comand.CommandText = "SP_ELIMINAR_CAT_REPUESTO";
                comand.Parameters.AddWithValue("@NUM_REPUESTO", NUM_REPUESTO);
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
