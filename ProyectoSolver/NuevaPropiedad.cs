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
    public partial class NuevaPropiedad : Form
    {
        public static int PrecioBase;
        public static int Precio;
        public static int Piso;
        public static int Sup;
        public static int IdPr;
        public static int Resp,Resp3;
        public static string Resp1 = "No se encuentra el propietario con ese ID";
        public static string Resp2 = "Letra incorrecta en tipo de lugar, vuelva a intentarlo";

        public NuevaPropiedad()

        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            PrecioBase = (int)numericUpDown4.Value;
            Piso = (int)numericUpDown7.Value;
            Sup = (int)numericUpDown5.Value;
            IdPr = (int)numericUpDown6.Value;

            DataSet1TableAdapters.Propietarios1TableAdapter tb =
            new DataSet1TableAdapters.Propietarios1TableAdapter();
            Resp = System.Convert.ToInt32(tb.ConsultaProp(IdPr));

            if (Resp == 1) 
            {
                

                if (textBox5.Text.ToUpper() == "C")
                {
                    if (comboBox3.Text == "Si")
                    {
                        Precio = PrecioBase + 10000;

                    }

                    else
                    {
                        Precio = PrecioBase;

                    }
                    DataSet1TableAdapters.Propiedades1TableAdapter tab =
                    new DataSet1TableAdapters.Propiedades1TableAdapter();
                    tab.AddLugar1(PrecioBase, Sup, IdPr, textBox5.Text, textBox3.Text, Precio, comboBox3.Text, 0, "no");
                    DataSet1TableAdapters.Propietarios1TableAdapter tba =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    Resp3 = System.Convert.ToInt32(tba.VerCT(IdPr));
                    DataSet1TableAdapters.Propietarios1TableAdapter tbaa =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    tbaa.ActCT(Precio + Resp3,IdPr);
                    this.Close();



                }
                if (textBox5.Text.ToUpper() == "D")
                {
                    Precio = PrecioBase + (1000 * Piso);

                    DataSet1TableAdapters.Propiedades1TableAdapter tba =
                   new DataSet1TableAdapters.Propiedades1TableAdapter();
                   tba.AddLugar1(PrecioBase, Sup, IdPr, textBox5.Text, textBox3.Text, Precio, "Ø", Piso, textBox4.Text);
                    DataSet1TableAdapters.Propietarios1TableAdapter tbaaa =
                   new DataSet1TableAdapters.Propietarios1TableAdapter();
                    Resp3 = System.Convert.ToInt32(tbaaa.VerCT(IdPr));
                    DataSet1TableAdapters.Propietarios1TableAdapter tbaa =
                    new DataSet1TableAdapters.Propietarios1TableAdapter();
                    tbaa.ActCT(Precio + Resp3, IdPr);
                    this.Close();
                }
                else
                {
                    lblOutput.Text = Resp2.ToString();
                }
                
            }
            else 
            {
                lblOutput.Text = Resp1.ToString();
            }

                  
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
