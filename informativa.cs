﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turiguate_5toA
{
    public partial class informativa : Form
    {
        public informativa()
        {
            InitializeComponent();
        }

        private void informativa_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Informacion_empresa informacionempresa = new Informacion_empresa();
            informacionempresa.Show();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
             como_se_creo comosecreo = new como_se_creo();
            comosecreo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            proposito_de_la_pagina propositodelapgina = new proposito_de_la_pagina();
           propositodelapgina.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
           mision misiondelapagina = new mision();
            misiondelapagina.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Visión Visiondelapagina = new Visión();
            Visiondelapagina.Show();
        }
    }
}
