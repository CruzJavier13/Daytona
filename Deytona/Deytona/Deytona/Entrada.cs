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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo_distribuidor.Enabled = false;
            txt_codigo_empleado.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_observaciones.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_subtotal.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_total.Enabled = false;

            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            txt_codigo_distribuidor.Enabled = false;
            txt_codigo_empleado.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_observaciones.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_subtotal.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_total.Enabled = false;

            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_codigo_distribuidor.Enabled = true;
            txt_codigo_empleado.Enabled = true;
            dtp_fecha.Enabled = true;
            txt_observaciones.Enabled = true;
            txt_cantidad.Enabled = true;
            txt_subtotal.Enabled = true;
            txt_impuesto.Enabled = true;
            txt_impuesto.Enabled = true;
            txt_total.Enabled = true;

            btn_Cancelar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            txt_codigo_distribuidor.Enabled = false;
            txt_codigo_empleado.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_observaciones.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_subtotal.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_total.Enabled = false;

            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            txt_codigo_distribuidor.Enabled = false;
            txt_codigo_empleado.Enabled = false;
            dtp_fecha.Enabled = false;
            txt_observaciones.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_subtotal.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_impuesto.Enabled = false;
            txt_total.Enabled = false;

            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
        }
    }
}
