using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deytona
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        Validacion v = new Validacion();
        private void Categoria_Load(object sender, EventArgs e)
        {
            //txt_Codigo.Enabled = false;
            txt_Nombre_Cat.Enabled = false;
            txt_Descripcion.Enabled = false;
            cmb_Estado.Enabled = false;

            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //txt_Codigo.Enabled = false;
            txt_Nombre_Cat.Enabled = false;
            txt_Descripcion.Enabled = false;
            cmb_Estado.Enabled = false;

            //txt_Codigo.Text = "";
            txt_Nombre_Cat.Text = "";
            txt_Descripcion.Text = "";
            cmb_Estado.Text = "Seleccione";

            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //txt_Codigo.Enabled = false;
            txt_Nombre_Cat.Enabled = true;
            txt_Descripcion.Enabled = true;
            cmb_Estado.Enabled = true;

            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Nuevo.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           // txt_Codigo.Enabled = false;
            txt_Nombre_Cat.Enabled = false;
            txt_Descripcion.Enabled = false;
            cmb_Estado.Enabled = false;

            //txt_Codigo.Text = "";
            txt_Nombre_Cat.Text = "";
            txt_Descripcion.Text = "";
            cmb_Estado.Text = "Seleccione";

            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
           // txt_Codigo.Enabled = false;
            txt_Nombre_Cat.Enabled = false;
            txt_Descripcion.Enabled = false;
            cmb_Estado.Enabled = false;

           // txt_Codigo.Text = "";
            txt_Nombre_Cat.Text = "";
            txt_Descripcion.Text = "";
            cmb_Estado.Text = "Seleccione";

            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void txt_Nombre_Cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
}
