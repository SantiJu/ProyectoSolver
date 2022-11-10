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
    public partial class NuevoPropietario : Form
    {
        public NuevoPropietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        DataSet1TableAdapters.Propietarios1TableAdapter ta =
                new DataSet1TableAdapters.Propietarios1TableAdapter();
            ta.AddProp1(AddNom.Text.Trim(), AddApe.Text.Trim(),AddTel1.Text,0);
            this.Close();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NuevoPropietario_Load(object sender, EventArgs e)
        {

        }
    }
}
