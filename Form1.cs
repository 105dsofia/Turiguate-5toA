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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            for (int i = 0; 1 < 5; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }
        
            
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haskell Dardon 05,Delia Godinez 07,Camila Godoy 08, Andrea Lopez 12");
        }
    }
}
