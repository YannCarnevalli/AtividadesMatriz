using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Vetores
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
            i = 0;
        }
        int[] a = new int[15];
        int[] b = new int[15];
        int x, i;

        private void btnapresentar_Click(object sender, EventArgs e)
        {

            txtapresentarA.Visible = true;
            txtapresentarB.Visible = true;

            for (i = 0; i <= 14; i++)
            {
                b[i] = a[i] * a[i];
            }
            for (i = 0; i <= 14; i++)
            {
                txtapresentarA.Text = string.Concat(txtapresentarA.Text, "  ", a[i].ToString());
                txtapresentarB.Text = string.Concat(txtapresentarB.Text, "  ", b[i].ToString());
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (i <= 14)
            {
                x = Convert.ToInt32(txtA.Text);
                a[i] = x;
                txtA.Clear();
                txtA.Focus();
                i++;
            }
            if (i >= 15)
            {
                MessageBox.Show("Vetor cheio");
                btnadicionar.Enabled = false;
                txtA.Enabled = false;
            }
        }

        private void Ex1_Load(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmmenu menu = new Frmmenu();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            i = 0;
            btnadicionar.Enabled = true;
            txtA.Enabled = true;
            txtA.Clear();
            txtA.Focus();
            txtapresentarA.Clear();
            txtapresentarB.Clear();
        }
    }
}
