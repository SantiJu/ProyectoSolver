using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProyectoSolver
{
    public partial class TablaGen : Form
        
    {
        public static int Resp;
        
        public TablaGen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Propietarios1' Puede moverla o quitarla según sea necesario.
            this.propietarios1TableAdapter.Fill(this.dataSet1.Propietarios1);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Propiedades' Puede moverla o quitarla según sea necesario.
            this.propiedadesTableAdapter.Fill(this.dataSet1.Propiedades);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ElegirElim frm = new ElegirElim();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElijaOpcion frm = new ElijaOpcion();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    

        private void TablaData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablaPrin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        } 

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Propietarios1TableAdapter ta =
            new DataSet1TableAdapters.Propietarios1TableAdapter();
            DataSet1.Propietarios1DataTable dt = ta.GetData();
            TablaPri.DataSource = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Propiedades1TableAdapter ta =
            new DataSet1TableAdapters.Propiedades1TableAdapter();
            DataSet1.Propiedades1DataTable dt = ta.GetData();
            TablaPri.DataSource = dt;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
         



        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElegirEdit frm = new ElegirEdit();
            frm.ShowDialog();
        }
    }

        
}