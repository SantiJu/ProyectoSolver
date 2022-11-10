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
    public partial class ElimPropiedad : Form
    {
        public ElimPropiedad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdLu = (int)numericUpDown1.Value;

            DataSet1TableAdapters.Propiedades1TableAdapter tb =
            new DataSet1TableAdapters.Propiedades1TableAdapter();
            int Resp = System.Convert.ToInt32(tb.ConsultaLugar(IdLu));

           
            if (Resp == 1)
            {
                DataSet1TableAdapters.Propiedades1TableAdapter tbu =
                new DataSet1TableAdapters.Propiedades1TableAdapter();
                int RespPr = System.Convert.ToInt32(tbu.VerProp(IdLu));

                DataSet1TableAdapters.Propiedades1TableAdapter tba =
                new DataSet1TableAdapters.Propiedades1TableAdapter();
                int Precio = System.Convert.ToInt32(tba.VerPT(IdLu));

                DataSet1TableAdapters.Propiedades1TableAdapter tbuu =
                new DataSet1TableAdapters.Propiedades1TableAdapter();
                tbuu.DeleteLugar(IdLu);

                DataSet1TableAdapters.Propietarios1TableAdapter tbah =
                new DataSet1TableAdapters.Propietarios1TableAdapter();
                int CapitalT = System.Convert.ToInt32(tbah.VerCT(RespPr));

                DataSet1TableAdapters.Propietarios1TableAdapter tbaa =
                new DataSet1TableAdapters.Propietarios1TableAdapter();
                tbaa.ActCT(CapitalT - Precio, RespPr);

                CartelElimLugar frm = new CartelElimLugar();
                frm.ShowDialog();
                this.Close();
            }

            else
            {
                string Resp2 = "No existe la propiedad con ese ID o ya fue eliminada";
                lblOutput.Text = Resp2.ToString();
            }
        }
    }
}
