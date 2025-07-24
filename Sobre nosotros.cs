using System;
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
    public partial class Sobre_nosotros : Form
    {
        public Sobre_nosotros()
        {
            InitializeComponent();
        }

        private void Sobre_nosotros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           haskell_dardon haskelldardon = new haskell_dardon();
           haskelldardon.Show();
        }
    }
}
