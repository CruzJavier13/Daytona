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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }
        Validacion v = new Validacion();
        private void Empleado_Load(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;

            //txt_CodigoEmpl.Enabled = false;
            //txt_Cedula.Enabled = false;
           
            txt_Inss.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            dtp_f_nacimiento.Enabled = false;
            cmb_Cargo.Enabled = false;
            cmb_Genero.Enabled = false;
            txt_Direccion.Enabled = false;
            cmb_EstadiCivil.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Correo.Enabled = false;
            txt_Web.Enabled = false;

            if(this.WindowState == FormWindowState.Maximized)
            {
                this.ShowIcon = false;
            }
            this.ShowIcon = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Nuevo.Enabled = false;

           // txt_CodigoEmpl.Enabled = false;
            //txt_Cedula.Enabled = true;
           
            txt_Inss.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Apellido.Enabled = true;
            dtp_f_nacimiento.Enabled = true;
            cmb_Cargo.Enabled = true;
            cmb_Genero.Enabled = true;
            txt_Direccion.Enabled = true;
            cmb_EstadiCivil.Enabled = true;
            txt_Telefono.Enabled = true;
            txt_Correo.Enabled = true;
            txt_Web.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;

            //txt_CodigoEmpl.Enabled = false;
            //txt_Cedula.Enabled = false;
           
            txt_Inss.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            dtp_f_nacimiento.Enabled = false;
            cmb_Cargo.Enabled = false;
            cmb_Genero.Enabled = false;
            txt_Direccion.Enabled = false;
            cmb_EstadiCivil.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Correo.Enabled = false;
            txt_Web.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;

            // txt_CodigoEmpl.Enabled = false;
            //txt_Cedula.Enabled = false;
            txt_cedula.Enabled = false;

            txt_Inss.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            dtp_f_nacimiento.Enabled = false;
            cmb_Cargo.Enabled = false;
            cmb_Genero.Enabled = false;
            txt_Direccion.Enabled = false;
            cmb_EstadiCivil.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Correo.Enabled = false;
            txt_Web.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
        }

        private void txt_Inss_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
}
