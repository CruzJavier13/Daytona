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
    public partial class Salida : Form
    {
        public Salida()
        {
            InitializeComponent();
        }

        private void Salida_Load(object sender, EventArgs e)
        {

        }

        private void cmb_opcionbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_opcionbusqueda.SelectedIndex == -1)
            {
                txt_Buscar.Visible = true;
                dtp_busqueda_fecha.Visible = false;
            }
            if (cmb_opcionbusqueda.SelectedIndex == 0)
            {
                txt_Buscar.Visible = true;
                dtp_busqueda_fecha.Visible = false;
            }
            if (cmb_opcionbusqueda.SelectedIndex == 1)
            {
                txt_Buscar.Visible = false;
                dtp_busqueda_fecha.Visible = true;
            }
        }
    }
}
