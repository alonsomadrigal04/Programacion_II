using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int paquetes = (int)numericUpDown1.Value;
            decimal precio;
            if (paquetes < 200)
            {
                precio = 4.50M;
            }
            else if (paquetes < 500)
            {
                precio = 3.75M;
            }
            else
            {
                precio = 3.25M;
            }
            label3.Text = precio.ToString("c");
        }
    }
}
