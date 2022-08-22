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
    public partial class Forma_Pago : Form
    {
        public Forma_Pago()
        {
            InitializeComponent();
        }

        private void Forma_Pago_Load(object sender, EventArgs e)
        {
            txt_nombre.Enabled = false;
            cmb_estado.Enabled = false;
        }
        
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_nombre.Enabled = true;
            cmb_estado.Enabled = true;

            btn_Nuevo.Enabled = false;
            btn_Cancelar.Enabled = true;
            btn_Guardar.Enabled = true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            cmb_estado.Text = "";

            txt_nombre.Enabled = false;
            cmb_estado.Enabled = false;

            btn_Nuevo.Enabled = true;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            cmb_estado.Text = "";

            btn_Nuevo.Enabled = true;
            btn_Cancelar.Enabled = false;
            btn_Guardar.Enabled = false;
        }
    }
}
