using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Division_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            clDivi divi = new clDivi(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
            textBox3.Text = divi.division().ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            textBox3.Clear();
        }
    }
}
