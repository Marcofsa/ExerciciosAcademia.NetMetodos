using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Lista11
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            frmEx1 ex1 = new frmEx1();
            ex1.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            frmEx2 ex2 = new frmEx2();
            ex2.Show();
        }
    }
}
