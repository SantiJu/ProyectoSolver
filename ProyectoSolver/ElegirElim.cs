﻿using System;
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
    public partial class ElegirElim : Form
    {
        public ElegirElim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElimPropietario frm = new ElimPropietario();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElimPropiedad frm = new ElimPropiedad();
            frm.ShowDialog();
            this.Close();
        }
    }
    
}
