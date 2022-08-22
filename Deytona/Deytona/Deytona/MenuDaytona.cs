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
    public partial class MenuDaytona : Form
    {
        public MenuDaytona()
        {
            InitializeComponent();
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void MenuDaytona_Load(object sender, EventArgs e)
        {

        }

        private void MenuDaytona_FormClosed(object sender, FormClosedEventArgs e)
        {

            Login login = new Login();
            login.Show();
        }

        private void gestionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.MdiParent = this;
            empleado.Show();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo();
            cargo.MdiParent = this;
            cargo.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio();
            servicio.MdiParent = this;
            servicio.Show();
        }

        private void detalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Factura_Servicio detalle_servicio = new Detalle_Factura_Servicio();
            detalle_servicio.MdiParent = this;
            detalle_servicio.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura_Repuesto factura = new Factura_Repuesto();
            factura.MdiParent = this;
            factura.Show();
        }

        private void detalleFacturaServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura_Servicio factura = new Factura_Servicio();
            factura.MdiParent = this;
            factura.Show();
        }

        private void gestionMonedaYPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Pago pago = new Forma_Pago();
            pago.MdiParent = this;
            pago.Show();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Moneda moneda = new Moneda();
            moneda.MdiParent = this;
            moneda.Show();
        }

        private void historialPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_Precio precio = new Historial_Precio();
            precio.MdiParent = this;
            precio.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.MdiParent = this;
            inventario.Show();
        }

        private void gestionarRepuesrtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lote lote = new Lote();
            lote.MdiParent = this;
            lote.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void precioRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Precio_Repuesto precio = new Precio_Repuesto();
            precio.MdiParent = this;
            precio.Show();
        }

        private void gestionarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salida salida = new Salida();
            salida.MdiParent = this;
            salida.Show();
        }

        private void tallerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Mantenimiento mantenimiento = new Tipo_Mantenimiento();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void tipoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Proveedor proveedor = new Tipo_Proveedor();
            proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void tipoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Servicio servicio = new Tipo_Servicio();
            servicio.MdiParent = this;
            servicio.Show();
        }

        private void gestionarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void gestionarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.MdiParent = this;
            vehiculo.Show();
        }

        private void vehiculoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculo_Cliente cliente = new Vehiculo_Cliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void tipoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_Cliente tipo = new Tipo_Cliente();
            tipo.MdiParent = this;
            tipo.Show();
        }

        private void detalleLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Lote detalle = new Detalle_Lote();
            detalle.MdiParent = this;
            detalle.Show();
        }

        private void documentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentacion doc = new Documentacion();
            doc.MdiParent = this;
            doc.Show();
        }

        private void equipoMecanicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipo_Mecanico equipo = new Equipo_Mecanico();
            equipo.MdiParent = this;
            equipo.Show();
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.MdiParent = this;
            factura.Show();
        }

        private void detalleFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Detalle_Factura_Vehiculo detalle = new Detalle_Factura_Vehiculo();
            detalle.MdiParent = this;
            detalle.Show();
        }
    }
}
