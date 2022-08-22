using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Deytona
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
        private void Bienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            hora_fecha.Start();
            timer1.Start();
            
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            //lbl_hora.Parent = pictureBox1;
            //lbl_fecha.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            //lbl_bienvenida.Parent = pictureBox1;
            lbl_derechos.Parent = pictureBox1;
            lbl_desarrollador.Parent = pictureBox1;
            lbl_nombre.Parent = pictureBox1;

            lbl_desarrollador.BackColor = Color.Transparent;
            lbl_nombre.BackColor = Color.Transparent;

            pictureBox2.BackColor = Color.Transparent;
            //lbl_bienvenida.BackColor = Color.Transparent;
            lbl_derechos.BackColor = Color.Transparent;

            //lbl_hora.BackColor = Color.Transparent;
            //lbl_fecha.BackColor = Color.Transparent; 
            
        }

        private void hora_fecha_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
           // progressBar1.Text = progressBar1.Value.ToString();
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                MenuDaytona Deytona = new MenuDaytona();
                Deytona.Show();
            }
        }
    }
}
