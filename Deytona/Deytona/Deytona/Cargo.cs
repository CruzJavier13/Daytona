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
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }
        Validacion v = new Validacion();
        private void Cargo_Load(object sender, EventArgs e)
        {
            txtEstado_Cargo.Enabled = false;
            txtNombreCargo.Enabled = false;

            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txtEstado_Cargo.Enabled = true;
            txtNombreCargo.Enabled = true;

            btn_Cancelar.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void txtEstado_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtNombreCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
}
