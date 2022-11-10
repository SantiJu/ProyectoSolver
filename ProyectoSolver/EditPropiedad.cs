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
    public partial class EditPropiedad : Form
    {
        public static int Precio, PrecioAnt, Resp3;
        public EditPropiedad()
        {
            InitializeComponent();
        }

        private void EditPropiedad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PrecioBase = (int)numericUpDown2.Value;
            int Piso = (int)numericUpDown4.Value;
            int Sup = (int)numericUpDown5.Value;
            int IdLu = (int)numericUpDown1.Value;
           

            DataSet1TableAdapters.Propiedades1TableAdapter tb =
            new DataSet1TableAdapters.Propiedades1TableAdapter();
            int Resp = System.Convert.ToInt32(tb.ConsultaLugar(IdLu));

            DataSet1TableAdapters.Propiedades1TableAdapter tbu =
            new DataSet1TableAdapters.Propiedades1TableAdapter();
            int RespPr = System.Convert.ToInt32(tbu.VerProp(IdLu));



            if (Resp == 1) 
            {
                DataSet1TableAdapters.Propiedades1TableAdapter tba =
                new DataSet1TableAdapters.Propiedades1TableAdapter();
                PrecioAnt = System.Convert.ToInt32(tba.VerPT(IdLu));

                if (textBox2.Text.ToUpper() == "C")
                {
                    if (comboBox1.Text == "Si")
                    {
                        Precio = PrecioBase + 10000;
                    }

                    else
                    {
                        Precio = PrecioBase;

                    }
                    DataSet1TableAdapters.Propiedades1TableAdapter tab =
                    new DataSet1TableAdapters.Propiedades1TableAdapter();
                    tab.UpdateLugar(PrecioBase, Sup, textBox2.Text, textBox1.Text, Precio, comboBox1.Text, 0, "no",IdLu);
                    DataSet1TableAdapters.Propietarios1TableAdapter tbag =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    Resp3 = System.Convert.ToInt32(tbag.VerCT(RespPr));
                    DataSet1TableAdapters.Propietarios1TableAdapter tbaa =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    tbaa.ActCT(Precio + Resp3 - PrecioAnt,RespPr) ;
                    this.Close();



                }
                if (textBox2.Text.ToUpper() == "D")
                {
                    Precio = PrecioBase + (1000 * Piso);

                    DataSet1TableAdapters.Propiedades1TableAdapter tbaa =
                    new DataSet1TableAdapters.Propiedades1TableAdapter();
                    tbaa.UpdateLugar(PrecioBase, Sup, textBox2.Text, textBox1.Text, Precio, "Ø", Piso, textBox3.Text,IdLu);
                    DataSet1TableAdapters.Propietarios1TableAdapter tbaaa =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    Resp3 = System.Convert.ToInt32(tbaaa.VerCT(RespPr));
                    DataSet1TableAdapters.Propietarios1TableAdapter tbaaaa =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    tbaaaa.ActCT(Precio + Resp3 - PrecioAnt, RespPr);
                    this.Close();
                }
                else
                {   
                    String Resp2 = ("Letra incorrecta en tipo de lugar, vuelva a intentar");
                    lblOutput.Text = Resp2.ToString();
                }
            }

            else
            {
                String Resp1 = "No se encuentra la propiedad con ese ID";
                lblOutput.Text = Resp1.ToString();
            }

        }
    }
}
