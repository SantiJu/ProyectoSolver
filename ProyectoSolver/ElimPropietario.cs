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
    public partial class ElimPropietario : Form
    {
        public ElimPropietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdPr = (int)numericUpDown1.Value;

            DataSet1TableAdapters.Propietarios1TableAdapter tb =
            new DataSet1TableAdapters.Propietarios1TableAdapter();
            int Resp = System.Convert.ToInt32(tb.ConsultaProp(IdPr));

            if (Resp == 1)
            {
                DataSet1TableAdapters.Propietarios1TableAdapter tbag =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                int Resp3 = System.Convert.ToInt32(tbag.VerCT(IdPr));

                if (Resp3 > 0)
                {
                    string Resp4 = "No se puede eliminar, tiene propiedades asignadas";
                    lblOutput.Text = Resp4.ToString();
                }

                else
                {
                    DataSet1TableAdapters.Propietarios1TableAdapter tbaa =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    tbaa.DeleteProp(IdPr);
                    CartelElimProp frm = new CartelElimProp();
                    frm.ShowDialog();
                    this.Close();

                }
            }

            else
            {
                string Resp1 = "No existe el propietario con ese ID o ya fue eliminado";
                lblOutput.Text = Resp1.ToString();
            }
        }
    }
}
