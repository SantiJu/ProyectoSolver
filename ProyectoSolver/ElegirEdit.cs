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
    public partial class ElegirEdit : Form
    {
        public ElegirEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPropietario frm = new EditPropietario();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditPropiedad frm = new EditPropiedad();
            frm.ShowDialog();
        }
    }
}
