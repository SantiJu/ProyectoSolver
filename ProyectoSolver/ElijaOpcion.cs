using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSolver
{
    public partial class ElijaOpcion : Form
    {
        public ElijaOpcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoPropietario frm = new NuevoPropietario();
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevaPropiedad frm = new NuevaPropiedad();
            frm.ShowDialog();
            this.Close();
        }
    }
}
