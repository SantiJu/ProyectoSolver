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
    public partial class EditPropietario : Form
    {
        public EditPropietario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditPropietario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdPr = (int)numericUpDown1.Value;

            DataSet1TableAdapters.Propietarios1TableAdapter tb =
            new DataSet1TableAdapters.Propietarios1TableAdapter();
            int Resp = System.Convert.ToInt32(tb.ConsultaProp(IdPr));

            if (Resp == 1)
            {
                DataSet1TableAdapters.Propietarios1TableAdapter tba =
            new DataSet1TableAdapters.Propietarios1TableAdapter();
                tba.UpdateProps(EditNom.Text.Trim(), EditApe.Text.Trim(), EditTel.Text, IdPr);
                this.Close();
            }

            else
            {
                string Resp1 = "No se encuentra el propietario con ese ID";
                lblOutput.Text = Resp1.ToString();
            }

        }
    }
}
