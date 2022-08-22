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
    public partial class Factura_Repuesto : Form
    {
        public Factura_Repuesto()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_num_repuesto.Text = "";
            txt_cantidad.Text = "";
            txt_precio_unidad.Text = "";
            txt_iva.Text = "";
            txt_total.Text = "";
            cmb_forma_pago.Text = "";
            cmb_moneda.Text = "";
            txt_descripcion.Text = "";
            txt_unidad.Text = "";
            txt_cliente.Text = "";
            txt_empleado.Text = "";
            //  txt_num_factura.Text = "";        
        }

    }
}
